// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#include "jitpch.h"
#ifdef _MSC_VER
#pragma hdrstop
#endif

#include "smallhash.h"

//---------------------------------------------------------------------------------------------------------------------
// DominatorCSE: a simple dominator-based CSE pass.
//
// This class imlpements CSE as a depth-first walk of the dominator tree that finds and replaces available CSEs as it
// goes.
//
// This pass does not perform any profitability heuristics beyond "can I CSE this operator"; instead, it assumes that
// any available CSE will be an improvement.
class DominatorCSE final : public Phase
{
    // ----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::Candidate: represents a tree that is a candidate for a CSE def.
    //
    // This encapsulates both the state needed to track a candidate tree and the logic necessary to transform it into a
    // def of a lclVar that holds the value of the eliminated expression.
    struct Candidate
    {
        GenTreeStmt* m_stmt; // The statement in which the candidate resides.
        GenTree* m_tree;     // The CSE candidate itself.
        unsigned m_lclNum;   // If this candidate has been promoted, the lclNum used for the CSE.

        Candidate()
        {
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatoreCSE::Candidate::Candidate: constructs a CSE def candidate.
        //
        // Arguments:
        //    stmt - The statment in which the candidate resides.
        //    tree - The candidate itself.
        Candidate(GenTreeStmt* stmt, GenTree* tree)
            : m_stmt(stmt), m_tree(tree)
        {
            assert(m_stmt != nullptr);
            assert(m_tree != nullptr);
        }

        // ------------------------------------------------------------------------------------------------------------
        // DominatorCSE::Candidate::Promote: transforms this candidate tree into a def of a lclVar if it has not yet
        //                                   been transformed.
        //
        // Arguments:
        //    compiler - The `Compiler` context to use for the transform.
        //    block    - The `BasicBlock` in which the def lives. Note that we pass this in as an argument in order to
        //               avoid carrying it with every candidate.
        //
        // Returns:
        //     The number of the lclVar that holds the value of this CSE.
        unsigned Promote(Compiler* compiler, BasicBlock* block)
        {
            assert(compiler != nullptr);
            assert(block != nullptr);

            // If this candidate has already been promoted, just return the CSE lclNum.
            if (m_tree->gtCSEnum == 1)
            {
                return m_lclNum;
            }

            // This had better be an actual candidate! Make sure it is and then mark it as promoted.
            assert(m_tree->gtCSEnum == -1);
            m_tree->gtCSEnum = 1;

#ifdef DEBUG
            if (compiler->verbose)
            {
                JITDUMP("Promoting tree to CSE def:\n");
                compiler->gtDispTree(m_tree);
                JITDUMP("\n");
            }
#endif

            // Grab a new temp for the CSE and mark it appropriately.
            m_lclNum = compiler->lvaGrabTemp(false DEBUGARG("Dominator CSE"));

            const var_types defType = m_tree->TypeGet();
            const var_types lclType = genActualType(defType);

            // TODO: handle struct CSEs.
            assert(!varTypeIsStruct(lclType));

            compiler->lvaTable[m_lclNum].lvType  = lclType;
            compiler->lvaTable[m_lclNum].lvIsCSE = true;
            compiler->lvaTable[m_lclNum].incRefCnts(block->getBBWeight(compiler), compiler);

            // Replace the original tree with one of the following:
            // - If the tree is the root of a statement:
            //      GT_ASG(GT_LCL_VAR(m_lclNum), tree);
            // - If the tree is not the root of a statement:
            //      GT_COMMA(GT_ASG(GT_LCL_VAR(m_lclNum), tree), GT_LCL_VAR(m_lclNum))
            GenTree** use;
            GenTree* parent = m_tree->gtGetParent(&use);

            GenTreeOp* const asg = compiler->gtNewTempAssign(m_lclNum, m_tree)->AsOp();
            assert(asg->OperIs(GT_ASG));
            assert(asg->gtOp1->OperIs(GT_LCL_VAR));
            assert(asg->gtOp2 == m_tree);

            // Repair execution order, which will be `m_tree => asg->gtOp1 => asg => next`. In order to avoid the
            // need to find the node that precedes the first node in `m_tree`, we set the reverse ops flag on the
            // assignment. This lets us link the destination lclVar in after `m_tree` rather than before.
            asg->gtFlags |= GTF_REVERSE_OPS;

            GenTree* const next = m_tree->gtNext;
            m_tree->gtNext = asg->gtOp1;

            asg->gtOp1->gtPrev = m_tree;
            asg->gtOp1->gtNext = asg;

            asg->gtPrev = asg->gtOp1;

            // Replace the use with the IR described above, updating flags up the tree's ancestors as necessary.
            if (parent == nullptr)
            {
                assert(next == nullptr);
                assert(m_stmt->gtStmtExpr == m_tree);
                m_stmt->gtStmtExpr = asg;
                m_stmt->gtFlags |= GTF_ASG;
            }
            else
            {
                assert(next != nullptr);

                GenTree* const load  = new (compiler, GT_LCL_VAR) GenTreeLclVar(defType, m_lclNum, BAD_IL_OFFSET);
                compiler->lvaTable[m_lclNum].incRefCnts(block->getBBWeight(compiler), compiler);

                GenTree* const comma = compiler->gtNewOperNode(GT_COMMA, defType, asg, load);
                comma->gtFlags |= GTF_ASG;

                // Set execution order for the comma tree, which will be asg > load > comma > next
                asg->gtNext = load;

                load->gtPrev = asg;
                load->gtNext = comma;

                comma->gtPrev = load;
                comma->gtNext = next;

                next->gtPrev = comma;

                // Replace the use and set the GTF_ASG flag for the tree's ancestors. If this node is used by a
                // `GT_LIST` node, it may be a call argument, in which case the call's argument table needs to be
                // updated with the replacement node.
                while ((parent != nullptr) && (parent->OperIs(GT_LIST)))
                {
                    parent->gtFlags |= GTF_ASG;
                    parent = parent->gtGetParent(nullptr);
                }
                if ((parent != nullptr) && parent->OperIs(GT_CALL))
                {
                    parent->AsCall()->ReplaceCallOperand(use, comma);
                }
                else
                {
                    *use = comma;
                }
                while ((parent != nullptr) && ((parent->gtFlags & GTF_ASG) == 0))
                {
                    parent->gtFlags |= GTF_ASG;
                    parent = parent->gtGetParent(nullptr);
                }
            }

#ifdef DEBUG
            if (compiler->verbose)
            {
                JITDUMP("After promotion:\n");
                compiler->gtDispTree(use == nullptr ? m_stmt->gtStmtExpr : *use);
                JITDUMP("\n");
            }
#endif

            return m_lclNum;
        }
    };

    //-----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::ScopedMap: a scoped map that tracks available CSE candidates.
    //
    // This type implements a map from value number to CSE candidate scoped by `BasicBlock`. Before a basic block is
    // visited, a scope for that block is pushed onto this map. Any CSE candidates that occur in that block are then
    // inserted into the map. Once all of the descendents of a basic block have been visited, its scope is popped
    // from the map, thereby removing any candidates in that block.
    class ScopedMap final
    {
        // The map type. Most blocks contain a smallish number of CSE candidates, so we start with a rather small
        // amount of inline storage.
        typedef SmallHashTable<ValueNum, Candidate, 8> CSEMap;

        // Represents a single scope as defined by a block and its map from value number to CSE candidate.
        struct Scope
        {
            BasicBlock* m_block;
            CSEMap* m_map;
        };

        Compiler* m_compiler;  // The compiler context for this map
        Scope     m_inline[8]; // Inline storage for the scope stack. Once this is exceeded we will use heap storage.
        Scope*    m_scopes;    // Pointer to the underlying array used for the scope stack. 
        unsigned  m_depth;     // The depth of the scope stack.
        unsigned  m_capacity;  // The capacity of the scope stack's underlying array.

    public:
        ScopedMap(Compiler* compiler)
            : m_compiler(compiler), m_scopes(m_inline), m_depth(0), m_capacity(sizeof(m_inline) / sizeof(m_inline[0]))
        {
            memset(m_scopes, 0, sizeof(Scope) * m_capacity);
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatorCSE::ScopedMap::Depth: returns the current number of active scopes.
        unsigned Depth()
        {
            return m_depth;
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatorCSE::ScopedMap::TopBlock: returns the block at the top of the scope.
        BasicBlock* TopBlock()
        {
            assert(m_depth > 0);
            return m_scopes[m_depth - 1].m_block;
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatorCSE::ScopedMap::Push: pushes a scope for `block` onto the stack and makes it active.
        //
        // Arguments:
        //    block - The block for the new scope.
        void Push(BasicBlock* block)
        {
            assert(block != nullptr);

            if (m_depth == m_capacity)
            {
                const unsigned delta       = m_capacity / 2;
                const unsigned newCapacity = m_capacity + delta;

                Scope* newScopes = new (m_compiler, CMK_CSE) Scope[newCapacity];
                memcpy(newScopes, m_scopes, sizeof(Scope) * m_capacity);
                memset(&newScopes[m_capacity], 0, sizeof(Scope) * delta);

                m_scopes = newScopes;
                m_capacity = newCapacity;
            }

            // If there's already a map at this level from a previous scope, reuse it. Otherwise, allocate a new map.
            Scope& scope = m_scopes[m_depth];
            scope.m_block = block;
            if (scope.m_map == nullptr)
            {
                scope.m_map = new (m_compiler, CMK_CSE) CSEMap(m_compiler);
            }
            else
            {
                scope.m_map->Clear();
            }

            m_depth++;
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatorCSE::ScopedMap::Pop: pops the currently active scope.
        void Pop()
        {
            assert(m_depth > 0);
            m_depth--;
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatorCSE::ScopedMap::AddDef: adds a candidate CSE def to the currently active scope.
        //
        // Arguments:
        //    stmt - The statement that contains the candidate tree.
        //    tree - The candidate tree itself.
        void AddDef(GenTreeStmt* stmt, GenTree* tree)
        {
            assert(stmt != nullptr);
            assert(tree != nullptr);
            assert(m_depth > 0);

            // This is arbitrary; it serves only to call out that this tree is an unpromoted CSE candidate.
            tree->gtCSEnum = -1;

            Candidate defCandidate(stmt, tree);
            m_scopes[m_depth - 1].m_map->AddOrUpdate(tree->GetVN(VNK_Liberal), defCandidate);
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatorCSE::ScopedMap::RemoveDef: removes a candidate CSE def from the currently active scope.
        //
        // Arguments:
        //    tree - The candidate tree to remove.
        void RemoveDef(GenTree* tree)
        {
            assert(tree != nullptr);
            assert(tree->gtCSEnum == -1);
            assert(m_depth > 0);

            Candidate candidate;
            bool removed = m_scopes[m_depth - 1].m_map->TryRemove(tree->GetVN(VNK_Liberal), &candidate);
            assert(removed);
            assert(candidate.m_tree == tree);
        }

        //-------------------------------------------------------------------------------------------------------------
        // DominatorCSE::ScopedMap::TryGetDef: given a tree, attempts to find an available tree that computes the same
        //                                     value.
        //
        // Any tree contained in the current scope or one of its ancestors is considered an available value.
        //
        // Arguments:
        //    tree         - The tree we are attempting to replace.
        //    defBlock     - An output parameter that will hold the block in which the def candidate resides if one is
        //                   found.
        //    defCandidate - An output parameter that will hold the def candidate itself, if one is found.
        //
        // Returns:
        //    True if a def candidate is found; false otherwise.
        bool TryGetDef(GenTree* tree, BasicBlock** defBlock, Candidate** defCandidate)
        {
            assert(tree != nullptr);
            assert(defBlock != nullptr);
            assert(defCandidate != nullptr);
            assert(m_depth > 0);

            const ValueNum vn = tree->GetVN(VNK_Liberal);
            for (int i = m_depth - 1; i >= 0; i--)
            {
                Scope& scope = m_scopes[i];
                if (scope.m_map->TryGetPointer(vn, defCandidate))
                {
                    *defBlock = scope.m_block;
                    return true;
                }
            }

            return false;
        }
    };

    ScopedMap m_scopedMap; // The scoped map that tracks available expressions.

    //-----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::ReplaceWithCSE: replaces a tree with a use of the given lclVar while preserving any required side
    //                               effects.
    //
    // Arguments:
    //    block  - The block in which the tree resides.
    //    stmt   - The statement in which the tree resides.
    //    tree   - The tree to replace.
    //    lclNum - The number of the lclVar that will be used to replace the tree.
    void ReplaceTreeWithCSE(BasicBlock* block, GenTreeStmt* stmt, GenTree* tree, const unsigned lclNum)
    {
#ifdef DEBUG
        if (comp->verbose)
        {
            JITDUMP("Replacing tree with CSE use:\n");
            comp->gtDispTree(tree);
        }
#endif
        comp->lvaTable[lclNum].incRefCnts(block->getBBWeight(comp), comp);

        // Grab the nodes that immediately precede and succeed the candidate tree in execution order. We will use these
        // later on in order to properly thread the replacement tree.
        GenTree* const prev = comp->fgGetFirstNode(tree)->gtPrev;
        GenTree* const next = tree->gtNext;

        // We need to do a bit of maintenance on the tree we're replacing:
        // - Any side effects need to be extracted
        // - Any unpromoted CSE candidates that are being deleted must be removed from the scope table
        //
        // We combine these operations into a single pre-oder walk.
        GenTree* sideEffects = nullptr;
        WalkTree::PreExecutionOrder(comp, tree, [this, &sideEffects](GenTree** use, GenTree* user) -> Compiler::fgWalkResult
        {
            if (user == nullptr)
            {
                return Compiler::WALK_CONTINUE;
            }

            GenTree* const node = *use;

            // If this node has side effects, extract it into the list and do not recurse.
            if (comp->gtNodeHasSideEffects(node, GTF_PERSISTENT_SIDE_EFFECTS_IN_CSE))
            {
                // Note that the call to `gtBuildCommaList` inverts the usual order of arguments. This is because
                // `gtBuildCommaList` prepends (rather than appends) to the list, since its only other user,
                // `gtExtractSideEffects`, visits trees in an order that requires prepending.
                sideEffects = sideEffects == nullptr ? node : comp->gtBuildCommaList(node, sideEffects);
                return Compiler::WALK_SKIP_SUBTREES;
            }

            // We should never see promoted CSE candidates during this walk, as they should all be children of
            // assignment nodes. Such nodes are side-effecting and should early-out above.
            assert(node->gtCSEnum != 1);

            // Otherwise, it is going to be removed. If it an unpromoted CSE candidate, unmark it.
            if (node->gtCSEnum == -1)
            {
                m_scopedMap.RemoveDef(node);
            }

            return Compiler::WALK_CONTINUE;
        });

        // Replace the candidate with a use of the CSE lclVar.
        // - If there are no side effects, simply turn the candidate into a lclVar node.
        // - If there are side effects, turn the candidate into GT_COMMA(sideEffects, GT_LCL_VAR(CSE)).
        GenTree* replacementFirstNode;
        if (sideEffects == nullptr)
        {
            tree->ChangeOper(GT_LCL_VAR, GenTree::PRESERVE_VN);
            tree->AsLclVarCommon()->SetLclNum(lclNum);
            tree->gtFlags &= GTF_NODE_MASK;

            replacementFirstNode = tree;
        }
        else
        {
            JITDUMP("Tree has side effects.\n");

            // Create a new use of the CSE lclVar
            GenTree* const cseUse = comp->gtNewLclvNode(lclNum, tree->TypeGet());

            // Stash the side effects in a comma node
            tree->ChangeOper(GT_COMMA, GenTree::PRESERVE_VN);
            tree->gtFlags = (tree->gtFlags & GTF_NODE_MASK) | (sideEffects->gtFlags & GTF_ALL_EFFECT);
            tree->AsOp()->gtOp1 = sideEffects;
            tree->AsOp()->gtOp2 = cseUse;

            // Repair execution order: prev -> sideEffects -> use -> comma -> next
            replacementFirstNode = comp->fgSetTreeSeq(sideEffects);

            sideEffects->gtNext = cseUse;
            cseUse->gtPrev = sideEffects;

            cseUse->gtNext = tree;
            tree->gtPrev   = cseUse;
        }

        replacementFirstNode->gtPrev = prev;
        if (prev != nullptr)
        {
            prev->gtNext = replacementFirstNode;
        }
        else
        {
            stmt->gtStmtList = replacementFirstNode;
        }

#ifdef DEBUG
        if (comp->verbose)
        {
            JITDUMP("After replacement:\n");
            comp->gtDispTree(tree);
            JITDUMP("\n");
            JITDUMP("\n");
        }
#endif
    }

    //-----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::CanCSEType: indicates whether or not we have the capability to CSE values of a given type.
    //
    // Arguments:
    //    type - The type in question.
    //
    // Returns:
    //    True if values of the given type can be CSE'd; false otherwise.
    static bool CanCSEType(var_types type)
    {
        // TODO-1stClassStructs: Enable CSE for struct types (depends on either transforming
        // to use regular assignments, or handling copyObj.
        if (varTypeIsStruct(type) || (type == TYP_VOID))
        {
            return false;
        }

#ifdef _TARGET_X86_
        // TODO-X86-CQ: Revisit this
        // Don't CSE a TYP_FLOAT on x86 as we currently can only enregister doubles
        return type != TYP_FLOAT;
#else
        return true;
#endif
    }

    //-----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::CanCSEOperator: indicates whether or not we have the capability to CSE a given operator.
    //
    // Arguments:
    //    oper - The operator in question.
    //
    // Returns:
    //    True if we have the capability to CSE nodes with the given operator; false otherwise.
    static bool CanCSEOperator(genTreeOps oper)
    {
        switch (oper)
        {
            case GT_ARR_ELEM:
            case GT_ARR_LENGTH:
            case GT_CLS_VAR:
            case GT_LCL_FLD:
            case GT_NEG:
            case GT_NOT:
            case GT_CAST:
            case GT_ADD:
            case GT_SUB:
            case GT_MUL:
            case GT_DIV:
            case GT_MOD:
            case GT_UDIV:
            case GT_UMOD:
            case GT_OR:
            case GT_AND:
            case GT_XOR:
            case GT_LSH:
            case GT_RSH:
            case GT_RSZ:
            case GT_ROL:
            case GT_ROR:
            case GT_EQ:
            case GT_NE:
            case GT_LT:
            case GT_LE:
            case GT_GE:
            case GT_GT:
            case GT_INTRINSIC:
            case GT_COMMA:
            case GT_CALL:
            case GT_IND:
#if CSE_CONSTS
            case GT_CNS_INT:
            case GT_CNS_LNG:
            case GT_CNS_STR:
#ifndef _TARGET_X86_
            // TODO-CQ: Revisit this
            // Don't try to CSE a GT_CNS_DBL as they can represent both float and doubles
            case GT_CNS_DBL:
#endif
#endif
                return true; // CSE these operators

            default:
                return false;
        }
    }

    //-----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::IsCSECandidate: indicates whether or not we have the capability to CSE a particular tree.
    //
    // We may not be able to CSE a particular node for any of the following reasons:
    // - The node's operator is not one that we are capable of handling for cost/legality/implementation concerns
    // - We may not have the capability to CSE expressions of the node's type (e.g. we cannot replace nodes of
    //   `TYP_VOID`).
    // - The node may have been called out as something we don't want to CSE
    // - The node may have side effects that preclude us from eliminating it
    //
    // Arguments:
    //    tree - The tree in question.
    //
    // Returns:
    //    True if we have the capability to CSE the tree.
    bool IsCSECandidate(GenTree* tree)
    {
        // If we either aren't capable of performing this CSE or do not feel that it is profitable, just return.
        //
        // Note that the vast majority of nodes with fail these checks. In order to keep them as fast as possible, they
        // are ordered s.t. most nodes are filtered out very early.
        if (!CanCSEOperator(tree->OperGet()) || !CanCSEType(tree->TypeGet()) || ((tree->gtFlags & GTF_DONT_CSE) != 0))
        {
            return false;
        }

        switch (tree->OperGet())
        {
            case GT_CALL:
                // If we have a simple helper call with no other persistent side-effects then we allow this tree to be
                // a CSE candidate.
                return !comp->gtNodeHasSideEffects(tree, GTF_PERSISTENT_SIDE_EFFECTS_IN_CSE);

            case GT_IND:
                // TODO-CQ: Review this...
                /* We try to cse GT_ARR_ELEM nodes instead of GT_IND(GT_ARR_ELEM).
                    Doing the first allows cse to also kick in for code like
                    "GT_IND(GT_ARR_ELEM) = GT_IND(GT_ARR_ELEM) + xyz", whereas doing
                    the second would not allow it */
                return (tree->gtOp.gtOp1->gtOper != GT_ARR_ELEM);

            case GT_ADD:
            case GT_MUL:
            case GT_LSH:
                // If these nodes are marked as being part of an address mode, do not CSE them.
                return (tree->gtFlags & GTF_ADDRMODE_NO_CSE) == 0;

            default:
                return true;
        }
    }

    //-----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::VisitBlock: walks each node in the given basic block, recording and eliminating available
    //                           expressions along the way.
    //
    // Arguments:
    //    block - The block to visit.
    void VisitBlock(BasicBlock* block)
    {
        for (GenTreeStmt* stmt = block->FirstNonPhiDef(); stmt != nullptr; stmt = stmt->getNextStmt())
        {
            for (GenTree* tree = stmt->gtStmtList; tree != nullptr; tree = tree->gtNext)
            {
                // We don't CSE assignment nodes or trees that are the RHS of an assignment to a lclVar.
                if (!IsCSECandidate(tree))
                {
                    continue;
                }

                ValueNum vnlib = tree->GetVN(VNK_Liberal);
                if (ValueNumStore::isReservedVN(vnlib))
                {
                    continue;
                }

                // Don't CSE constant values, instead let the Value Number based Assertion Prop phase handle them.
                if (comp->vnStore->IsVNConstant(vnlib))
                {
                    continue;
                }

                // Check to see if there is an existing def of this value number. If there is not, add the current tree
                // to the scope table and carry on. If there is a def, either update the candidate (in the case of
                // comma nodes) or promote the def and CSE away this tree away.
                BasicBlock* defBlock;
                Candidate*  defCandidate;
                if (!m_scopedMap.TryGetDef(tree, &defBlock, &defCandidate))
                {
                    m_scopedMap.AddDef(stmt, tree);
                    continue;
                }

                // If this node is a comma node and the candidate is its RHS, do not perform the CSE: instead, change
                // the candidate to the comma node. This avoids introducing additional IR for a case that would have
                // just passed through the CSE lclVar.
                //
                // Note that this is really a special case of a tree that simply passes through the value of one of its
                // children. It may be worth extending this logic to catch the common case.
                if (tree->OperIs(GT_COMMA))
                {
                    GenTreeOp* const comma = tree->AsOp();
                    if (comma->gtOp2 == defCandidate->m_tree)
                    {
                        assert(defCandidate->m_stmt == stmt);
                        defCandidate->m_tree->gtCSEnum = 0;
                        defCandidate->m_tree = comma;
                        comma->gtCSEnum = -1;
                        continue;
                    }
                }

                // Okay, we have a CSE to perform. First promote the def, then replace the tree with a use of the CSE
                // lclVar.
                ReplaceTreeWithCSE(block, stmt, tree, defCandidate->Promote(comp, defBlock));
            }
        }
    }

public:
    DominatorCSE(Compiler* compiler)
        : Phase(compiler, "Dominator CSE", PHASE_OPTIMIZE_DOM_CSE), m_scopedMap(compiler)
    {
    }

    //-----------------------------------------------------------------------------------------------------------------
    // DominatorCSE::DoPhase: runs the dominator-based CSE phase.
    void DoPhase() override
    {
        // Because we are about to walk the dominator tree, we first need to ensure that it is up-to-date.
        if (comp->fgModified)
        {
            comp->fgUpdateChangedFlowGraph();
        }
        assert(comp->fgDomsComputed);

        // Build the pre-order and post-order block lists. We will use these to traverse the dominator tree.
        const unsigned bbDomCount = comp->fgDomBBcount;

        BasicBlock** preOrder = new (comp, CMK_CSE) BasicBlock*[bbDomCount];
        BasicBlock** postOrder = new (comp, CMK_CSE) BasicBlock*[bbDomCount];

        for (BasicBlock* block = comp->fgFirstBB; block != nullptr; block = block->bbNext)
        {
            assert(block->bbNum <= bbDomCount);

            const unsigned preIndex = comp->fgDomTreePreOrder[block->bbNum] - 1;
            preOrder[preIndex] = block;

            const unsigned postIndex = comp->fgDomTreePostOrder[block->bbNum] - 1;
            postOrder[postIndex] = block;
        }

#ifdef DEBUG
        if (comp->verbose)
        {
            JITDUMP("\nPreorder dominator tree traversal:");
            for (unsigned cursor = 0; cursor < bbDomCount; cursor++)
            {
                JITDUMP(" BB%02u", preOrder[cursor]->bbNum);
            }

            JITDUMP("\nPostorder dominator tree traversal:");
            for (unsigned cursor = 0; cursor < bbDomCount; cursor++)
            {
                JITDUMP(" BB%02u", postOrder[cursor]->bbNum);
            }
            JITDUMP("\n\n");
        }
#endif

        unsigned postCursor = 0;
        for (unsigned preCursor = 0; preCursor < bbDomCount; preCursor++)
        {
            BasicBlock* block = preOrder[preCursor];
            m_scopedMap.Push(block);

            JITDUMP("*** Preorder move %d: BB%02u (%d dominators)\n", preCursor, block->bbNum, m_scopedMap.Depth());

            VisitBlock(block);

            while ((m_scopedMap.Depth() > 0) && (m_scopedMap.TopBlock() == postOrder[postCursor]))
            {
                JITDUMP("*** Postorder move %d: pop BB%02u\n", postCursor, m_scopedMap.TopBlock()->bbNum);

                m_scopedMap.Pop();
                postCursor++;
            }
        }
    }
};

void Compiler::optOptimizeDomCSEs()
{
    optCSEstart = lvaCount;

    DominatorCSE domCse(this);
    domCse.Run();

    optCSEcount = lvaCount - optCSEstart;
}
