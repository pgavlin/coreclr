// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


#include "jitpch.h"
#ifdef _MSC_VER
#pragma hdrstop
#endif

#ifdef DEBUG

void dumpMethod()
{
    if (VERBOSE)
        JitTls::GetCompiler()->fgDispBasicBlocks(true);
}

void dumpTreeStack(Compiler *comp, ArrayStack<GenTree *> *stack)
{
    printf("=TOS=================\n");
    for (int i=0; i<stack->Height(); i++)
    {
        comp->gtDispNode(stack->Index(i), 0, "");
        printf("\n");
    }
    printf("=====================\n");
}

void dumpArgTable(Compiler *comp, GenTree *call)
{
    noway_assert(call->IsCall());
    fgArgInfoPtr argInfo = call->gtCall.fgArgInfo;
    noway_assert(argInfo != NULL);

    unsigned            argCount = argInfo->ArgCount();
    fgArgTabEntryPtr *  argTable = argInfo->ArgTable();
    fgArgTabEntryPtr    curArgTabEntry = NULL; 

    JITDUMP("ARG TABLE for call ");
    Compiler::printTreeID(call);
    JITDUMP(":\n");
    for (unsigned i=0; i < argCount; i++)
    {
        curArgTabEntry = argTable[i];
        JITDUMP("entry %d\n", i);
        DISPTREE(curArgTabEntry->node);
    }
    JITDUMP("--------------ARG TABLE END --------------\n");
}

#endif // DEBUG



// state carried over the tree walk, to be used in making
// a splitting decision.
struct SplitData
{
    GenTree *root; // root stmt of tree being processed
    BasicBlock *block;
    Rationalizer *thisPhase;
};

//------------------------------------------------------------------------------
// isNodeCallArg - given a context (stack of parent nodes), determine if the TOS is an arg to a call
//------------------------------------------------------------------------------

GenTree *isNodeCallArg(ArrayStack<GenTree *> *parentStack)
{
    for (int i = 1; // 0 is current node, so start at 1
         i < parentStack->Height();
         i++)
    {
        GenTree *node = parentStack->Index(i);
        switch (node->OperGet())
        {
        case GT_LIST:
        case GT_ARGPLACE:
            break;
        case GT_NOP:
            // Currently there's an issue when the rationalizer performs
            // the fixup of a call argument: the case is when we remove an
            // inserted NOP as a parent of a call introduced by fgMorph;
            // when then the rationalizer removes it, the tree stack in the 
            // walk is not consistent with the node it was just deleted, so the
            // solution is just to go 1 level deeper.
            // TODO-Cleanup: This has to be fixed in a proper way: make the rationalizer 
            // correctly modify the evaluation stack when removing treenodes.
            if (node->gtOp.gtOp1->gtOper == GT_CALL)
            {
                return node->gtOp.gtOp1;
            }
            break;
        case GT_CALL:
            return node;
        default:
            return NULL;
        }
    }
    return NULL;
}

//------------------------------------------------------------------------------
// fgMakeEmbeddedStmt: insert the given subtree as an embedded statement
//
// Arguments:
//    block - The block containing the parentStmt, into which the new embedded
//            statement will go
//    tree  - The tree that will be the gtStmtExpr of the new embedded statement
//    parentStmt - A statement (top-level or embedded) that 'tree' is fully contained in
//
// Return Value:
//    A pointer to the new statement.
//
// Assumptions:
//    'tree' is fully contained in the linear order of parentStmt
//
// Notes:
//    If 'tree' is at the beginning of the linear order of 'parentStmt', it
//    is made into a top-level statement.

GenTreeStmt*
Compiler::fgMakeEmbeddedStmt(BasicBlock* block, GenTree* tree, GenTree* parentStmt)
{
    assert(tree->gtOper != GT_STMT);
    assert(parentStmt->gtOper == GT_STMT);
    assert(fgBlockContainsStatementBounded(block, parentStmt));

    GenTreePtr newStmtFirstNode = fgGetFirstNode(tree);
    GenTreePtr parentStmtFirstNode = parentStmt->gtStmt.gtStmtList;
    GenTreePtr prevStmt = parentStmt;
    bool newTopLevelStmt = false;
    bool splitParentStmt = false;
    if (newStmtFirstNode == parentStmtFirstNode)
    {
        // If this is the first node of the new statement, split them.
        parentStmt->gtStmt.gtStmtList = tree->gtNext;
        prevStmt = parentStmt->gtPrev;
        splitParentStmt = true;
    }
    GenTreeStmt* newStmt = gtNewStmt(tree, parentStmt->gtStmt.gtStmtILoffsx);    // Use same IL offset as parent statement
    newStmt->CopyCosts(tree);
    newStmt->gtStmtList = newStmtFirstNode;
    if (splitParentStmt && parentStmt->gtStmt.gtStmtIsTopLevel())
    {
        newTopLevelStmt = true;
        tree->gtNext->gtPrev = nullptr;
        tree->gtNext = nullptr;
    }
    else
    {
        newStmt->gtFlags &= ~(GTF_STMT_TOP_LEVEL);
    }

    // Does parentStmt already have embedded statements?
    // If so, determine where this fits in the linear order.
    // Note that if we have the splitParentStmt case, some of parentStmt's embedded statements
    // may need to move with the new statement
    GenTreePtr nextStmt = parentStmt->gtNext;
    GenTreePtr nextLinearNode;
    GenTreePtr searchNode;
    if (splitParentStmt)
    {
        nextLinearNode = newStmtFirstNode;
        // In this case, we're going to search for the LAST linear node in the new statement
        // in order to determine which embedded statements will move with this one.
        searchNode = tree;
    }
    else
    {
        nextLinearNode = parentStmt->gtStmt.gtStmtList;
        // In this case, we're going to search for the FIRST linear node in the new statement
        // so that we can insert this after any embedded statements that START before it.
        searchNode = newStmtFirstNode;
    }
    // Remember if we find any embedded statements before encountering 'searchNode'.
    bool foundEmbeddedStmts = false;
    while (nextStmt != nullptr && nextStmt->gtStmt.gtStmtIsEmbedded())
    {
        GenTreePtr nextEmbeddedNode = nextStmt->gtStmt.gtStmtList;
        while (nextLinearNode != searchNode && nextLinearNode != nextEmbeddedNode)
        {
            nextLinearNode = nextLinearNode->gtNext;
            assert (nextLinearNode != nullptr);
        }
        if (nextLinearNode == searchNode)
            break;
        prevStmt = nextStmt;
        nextStmt = nextStmt->gtNext;
        foundEmbeddedStmts = true;
    }

    if (newTopLevelStmt)
    {
        // For this case, we are actually going to insert it BEFORE parentStmt.
        // However if we have a new prevStmt (i.e. there are some embedded statements
        // to be included in newStmt) then those need to be moved as well.
        // Note, however, that all the tree links have already been fixed up.
        fgInsertStmtBefore(block, parentStmt, newStmt);
        if (foundEmbeddedStmts)
        {
            GenTreePtr firstEmbeddedStmt = parentStmt->gtNext;
            assert(firstEmbeddedStmt->gtStmt.gtStmtIsEmbedded());
            assert(prevStmt->gtStmt.gtStmtIsEmbedded());
            parentStmt->gtNext = prevStmt->gtNext;
            if (parentStmt->gtNext != nullptr)
            {
                parentStmt->gtNext->gtPrev = parentStmt;
            }
            else
            {
                block->bbTreeList->gtPrev = parentStmt;
            }

            parentStmt->gtPrev = prevStmt;
            prevStmt->gtNext = parentStmt;

            newStmt->gtNext = firstEmbeddedStmt;
            firstEmbeddedStmt->gtPrev = newStmt;
        }
    }
    else
    {
        fgInsertStmtAfter(block, prevStmt, newStmt);
    }

    return newStmt;
}

//------------------------------------------------------------------------------
// fgInsertLinearNodeBefore: insert the given single node before 'before'.
//
// Arguments:
//    newNode - The node to be inserted
//    before  - The node to insert it before
//
// Return Value:
//    None.
//
// Assumptions:
//    Either the callee must ensure that 'before' is part of compCurStmt,
//    or before->gtPrev must be non-null

void
Compiler::fgInsertLinearNodeBefore(GenTreePtr newNode, GenTreePtr before)
{
    GenTreePtr prevNode = before->gtPrev;
    newNode->gtPrev = prevNode;
    if (prevNode == nullptr)
    {
        assert(compCurStmt->gtStmt.gtStmtList == before && compCurStmt->gtStmt.gtStmtIsTopLevel());
    }
    else
    {
        prevNode->gtNext = newNode;
    }
    // Note that 'before' may be the first node in gtStmtList even if its gtPrev is non-null,
    // since compCurStmt may be embedded.
    if (compCurStmt->gtStmt.gtStmtList == before)
    {
        compCurStmt->gtStmt.gtStmtList = newNode;
    }
    newNode->gtNext = before;
    before->gtPrev = newNode;
}

//-----------------------------------------------------------------------------------------------
// fgInsertEmbeddedFormTemp: Assign a variable to hold the result of *ppTree, possibly creating a new variable
//                           and creating a new (possibly embedded) statement for it.  The original
//                           subtree will be replaced with a use of the temp.
//
// Arguments:
//    ppTree  - a pointer to the child node we will be replacing with a reference to the new temp.
//    lclNum  - local var to use, or BAD_VAR_NUM to create one
//
// Return Value:
//    The new statement.
//
// Assumptions:
//    The caller must ensure that '*ppTree' is part of compCurStmt, and that
//    compCurStmt is in compCurBB;

GenTreeStmt*
Compiler::fgInsertEmbeddedFormTemp(GenTree** ppTree, unsigned lclNum)
{
    GenTree* subTree = *ppTree;

    if (lclNum == BAD_VAR_NUM)
    {
        lclNum = lvaGrabTemp(true DEBUGARG("fgInsertEmbeddedFormTemp is creating a new local variable"));
    }

    // Increment its lvRefCnt and lvRefCntWtd twice, one for the def and one for the use
    lvaTable[lclNum].incRefCnts(compCurBB->getBBWeight(this), this);
    lvaTable[lclNum].incRefCnts(compCurBB->getBBWeight(this), this);

    GenTreeLclVar* store = gtNewTempAssign(lclNum, subTree)->AsLclVar();
    gtSetEvalOrder(store);

    subTree->InsertAfterSelf(store);

    GenTree* load = new (this, GT_LCL_VAR) GenTreeLclVar(store->TypeGet(), store->AsLclVarCommon()->GetLclNum(), BAD_IL_OFFSET);
    gtSetEvalOrder(load);

    store->InsertAfterSelf(load);

    *ppTree = load;

    JITDUMP("fgInsertEmbeddedFormTemp created store :\n");
    DISPTREE(store);

    GenTreeStmt* stmt = fgMakeEmbeddedStmt(compCurBB, store, compCurStmt);
    stmt->gtStmtILoffsx = compCurStmt->gtStmt.gtStmtILoffsx;
#ifdef DEBUG
    stmt->gtStmtLastILoffs = compCurStmt->gtStmt.gtStmtLastILoffs;
#endif // DEBUG

    return stmt;
}

// return op that is the store equivalent of the given load opcode
genTreeOps storeForm(genTreeOps loadForm)
{
    switch (loadForm)
    {
    case GT_LCL_VAR:
        return GT_STORE_LCL_VAR;
    case GT_LCL_FLD:
        return GT_STORE_LCL_FLD;
    case GT_REG_VAR:
        noway_assert(!"reg vars only supported in classic backend\n");
        unreached();
    default:
        noway_assert(!"not a data load opcode\n");
        unreached();
    }
}

// return op that is the addr equivalent of the given load opcode
genTreeOps addrForm(genTreeOps loadForm)
{
    switch (loadForm)
    {
    case GT_LCL_VAR:
        return GT_LCL_VAR_ADDR;
    case GT_LCL_FLD:
        return GT_LCL_FLD_ADDR;
    default:
        noway_assert(!"not a data load opcode\n");
        unreached();
    }
}

// copy the flags determined by mask from src to dst
void copyFlags(GenTree *dst, GenTree *src, unsigned mask)
{
    dst->gtFlags &= ~mask;
    dst->gtFlags |= (src->gtFlags & mask);
}

// call args have other pointers to them which must be fixed up if 
// they are replaced
void Compiler::fgFixupIfCallArg(ArrayStack<GenTree *> *parentStack,
                                  GenTree *oldChild, 
                                  GenTree *newChild)
{
    GenTree *parentCall = isNodeCallArg(parentStack);
    if (!parentCall) 
    {
        DBEXEC(VERBOSE, dumpTreeStack(JitTls::GetCompiler(), parentStack));
        return;
    }
     
    // we have replaced an arg, so update pointers in argtable
    fgFixupArgTabEntryPtr(parentCall, oldChild, newChild);
}

//------------------------------------------------------------------------
// fgFixupArgTabEntryPtr: Fixup the fgArgTabEntryPtr of parentCall after 
//                        replacing oldArg with newArg 
//
// Arguments:
//    parentCall - a pointer to the parent call node
//    oldArg     - the original argument node
//    newArg     - the replacement argument node
//

void Compiler::fgFixupArgTabEntryPtr(GenTreePtr parentCall,
                                     GenTreePtr oldArg,
                                     GenTreePtr newArg)
{
    assert(parentCall != nullptr);
    assert(oldArg != nullptr);
    assert(newArg != nullptr);

    JITDUMP("parent call was :\n");
    DISPTREE(parentCall);

    JITDUMP("old child was :\n");
    DISPTREE(oldArg);
    
    if (oldArg->gtFlags & GTF_LATE_ARG)
    {
        newArg->gtFlags |= GTF_LATE_ARG;
    }
    else
    {
        fgArgTabEntryPtr fp = Compiler::gtArgEntryByNode(parentCall, oldArg);
        assert(fp->node == oldArg);
        fp->node = newArg;
    }

    JITDUMP("parent call:\n");
    DISPTREE(parentCall);
}

// Rewrite InitBlk involving SIMD vector into stlcl.var of a SIMD type.
//
// Arguments:
//    ppTree      - A pointer-to-a-pointer for the GT_INITBLK
//    fgWalkData  - A pointer to tree walk data providing the context
//
// Return Value:
//    None.
//
// TODO-Cleanup: Once SIMD types are plumbed through the frontend, this will no longer
// be required.
//
void Rationalizer::RewriteInitBlk(GenTree** use)
{   
#ifdef FEATURE_SIMD
    // No lowering is needed for non-SIMD nodes, so early out if featureSIMD is not enabled.
    if (!comp->featureSIMD) 
    {
        return;
    }

    // See if this is a SIMD initBlk that needs to be changed to a simple st.lclVar.
    GenTreeInitBlk* initBlk = (*use)->AsInitBlk();

    // Is the dstAddr is addr of a SIMD type lclVar?
    GenTree* dstAddr = initBlk->Dest();
    if (dstAddr->OperGet() != GT_ADDR)
    {
        return;
    }

    GenTree* dst = dstAddr->gtGetOp1();        
    var_types baseType = comp->getBaseTypeOfSIMDLocal(dst);
    if (baseType == TYP_UNKNOWN)
    {
        return;
    }
    CORINFO_CLASS_HANDLE typeHnd = comp->lvaTable[dst->AsLclVarCommon()->gtLclNum].lvVerTypeInfo.GetClassHandle();
    unsigned simdLocalSize = comp->getSIMDTypeSizeInBytes(typeHnd);

    JITDUMP("Rewriting SIMD InitBlk\n");
    DISPTREE(initBlk);

    assert((dst->gtFlags & GTF_VAR_USEASG) == 0);

    // There are currently only three sizes supported: 8 bytes, 16 bytes or the vector register length.
    GenTreeIntConCommon* sizeNode = initBlk->Size()->AsIntConCommon();
    unsigned int size = (unsigned int) roundUp(sizeNode->IconValue(), TARGET_POINTER_SIZE);
    var_types simdType = comp->getSIMDTypeForSize(size);
    assert(roundUp(simdLocalSize, TARGET_POINTER_SIZE) == size);

    GenTree* initVal = initBlk->InitVal();
    GenTreeSIMD* simdNode = new (comp, GT_SIMD) GenTreeSIMD(simdType, initVal, SIMDIntrinsicInit, baseType, (unsigned)sizeNode->IconValue());

    dst->SetOper(GT_STORE_LCL_VAR);
    GenTreeLclVar* store = dst->AsLclVar();
    store->gtType = simdType;
    store->gtOp.gtOp1 = simdNode;
    store->gtFlags |= (simdNode->gtFlags & GTF_ALL_EFFECT);

    // Insert the new nodes into the block
    m_block->InsertNodeAfter(simdNode, initVal);
    m_block->InsertNodeAfter(store, simdNode);
    m_block->ReplaceUseWith(use, store);

    // Remove the old GT_ADDR, size, and GT_INITBLK nodes.
    m_block->RemoveNode(dstAddr);
    m_block->RemoveNode(sizeNode);
    m_block->RemoveNode(initBlk);

    JITDUMP("After rewriting SIMD InitBlk:\n");
    DISPTREE(*use);
    JITDUMP("\n");
#endif // FEATURE_SIMD
}

// Transform CopyBlk involving SIMD vectors into stlclvar or stind of a SIMD type.
// Transformation is done if either src or dst are known to be SIMD vectors.
//
// Arguments:
//    ppTree      - A pointer-to-a-pointer for the GT_COPYBLK
//    fgWalkData  - A pointer to tree walk data providing the context
//
// Return Value:
//    None.
//
// If either the source or the dst are known to be SIMD (a lclVar or SIMD intrinsic),
// get the simdType (TYP_DOUBLE or a SIMD type for SSE2) from the size of the SIMD node.
// 
// For the source:
// - If it is a SIMD intrinsic or a lvSIMDType lclVar, change the node type to simdType.
// - Otherwise, add a GT_IND of simdType.
// For the dst:
// - If it is a lclVar of a SIMD type, chanage the node type to simdType.
// - Otherwise, change it to a GT_STORE_IND of simdType
//
// TODO-Cleanup: Once SIMD types are plumbed through the frontend, this will no longer
// be required.
//
void Rationalizer::RewriteCopyBlk(GenTree** use)
{   
#ifdef FEATURE_SIMD
    // No need to transofrm non-SIMD nodes, if featureSIMD is not enabled.
    if (!comp->featureSIMD) 
    {
        return;
    }

    // See if this is a SIMD copyBlk
    GenTreeCpBlk* cpBlk = (*use)->AsCpBlk();
    GenTreePtr dstAddr = cpBlk->Dest();
    GenTree* srcAddr = cpBlk->Source();

    // Do not transform if neither src or dst is known to be a SIMD type.
    // If src tree type is something we cannot reason but if dst is known to be of a SIMD type
    // we will treat src tree as a SIMD type and vice versa.
    if (!(comp->isAddrOfSIMDType(srcAddr) || comp->isAddrOfSIMDType(dstAddr)))
    {
        return;
    }

    // At this point it is known to be a copyblk of SIMD vectors and we can 
    // start transforming the original tree. Prior to this point do not perform
    // any modifications to the original tree.
    JITDUMP("\nRewriting SIMD CopyBlk\n");
    DISPTREE(cpBlk);

    // There are currently only three sizes supported: 8 bytes, 12 bytes, 16 bytes or the vector register length.
    GenTreeIntConCommon* sizeNode = cpBlk->Size()->AsIntConCommon();
    var_types simdType = comp->getSIMDTypeForSize((unsigned int) sizeNode->IconValue());

    // Remove 'size' from execution order
    m_block->RemoveNode(sizeNode);

    // Is destination a lclVar which is not an arg?
    // If yes then we can turn it to a stlcl.var, otherwise turn into stind.
    GenTree* simdDst = nullptr;
    genTreeOps oper = GT_NONE;
    if (dstAddr->OperGet() == GT_ADDR && comp->isSIMDTypeLocal(dstAddr->gtGetOp1()))
    {
        // Get rid of parent node in GT_ADDR(GT_LCL_VAR)
        m_block->RemoveNode(dstAddr);

        simdDst = dstAddr->gtGetOp1();
        simdDst->gtType = simdType;
        oper = GT_STORE_LCL_VAR;

        // For structs that are padded (e.g. Vector3f, Vector3i), the morpher will have marked them
        // as GTF_VAR_USEASG.  Unmark them.
        simdDst->gtFlags &= ~(GTF_VAR_USEASG);
    }
    else
    {
        // Address of a non-local var
        simdDst = dstAddr;
        oper = GT_STOREIND;
    }

    // Src: Get rid of parent node of GT_ADDR(..) if its child happens to be of a SIMD type.
    GenTree* simdSrc = nullptr;
    if (srcAddr->OperGet() == GT_ADDR && varTypeIsSIMD(srcAddr->gtGetOp1()))
    {
        m_block->RemoveNode(srcAddr);
        simdSrc = srcAddr->gtGetOp1();
    }
    else
    {
        // Since destination is known to be a SIMD type, src must be a SIMD type too
        // though we cannot figure it out easily enough. Transform src into
        // GT_IND(src) of simdType.
        //
        // We need to initialize costs on indir so that CopyCosts() while creating
        // an addrmode will not hit asserts. These costs are not used further down
        // but setting them to a reasonable value based on the logic in gtSetEvalOrder().
        GenTree* indir = comp->gtNewOperNode(GT_IND, simdType, srcAddr);
        indir->SetCosts(IND_COST_EX, 2);
        m_block->InsertNodeAfter(indir, srcAddr);
        
        cpBlk->gtGetOp1()->gtOp.gtOp2 = indir;
        simdSrc = indir;
    }
    simdSrc->gtType = simdType;

    // Change cpblk to either a st.lclvar or st.ind.
    // At this point we are manipulating cpblk node with the knowledge of
    // its internals (i.e. op1 is the size node, and the src & dst are in a GT_LIST on op2).
    // This logic might need to be changed if we ever restructure cpblk node.

    assert(simdDst != nullptr);
    assert(simdSrc != nullptr);

    GenTree* newNode = nullptr;
    GenTree* list = cpBlk->gtGetOp1();
    if (oper == GT_STORE_LCL_VAR)
    {
        // get rid of the list node
        m_block->RemoveNode(list);

        newNode = simdDst;
        newNode->SetOper(oper);

        GenTreeLclVar* store = newNode->AsLclVar();
        store->gtOp1 = simdSrc;         
        store->gtType = simdType;
        store->gtFlags |= (simdSrc->gtFlags & GTF_ALL_EFFECT);

        m_block->RemoveNode(simdDst);
        m_block->InsertNodeAfter(simdDst, simdSrc);
    }
    else
    {
        assert(oper == GT_STOREIND);

        newNode = list;
        newNode->SetOper(oper);

        GenTreeStoreInd* storeInd = newNode->AsStoreInd();
        storeInd->gtType = simdType;
        storeInd->gtFlags |= (simdSrc->gtFlags & GTF_ALL_EFFECT);
        storeInd->gtOp1 = simdDst;
        storeInd->gtOp2 = simdSrc;
    } 

    m_block->ReplaceUseWith(use, newNode);
    m_block->RemoveNode(cpBlk);

    JITDUMP("After rewriting SIMD CopyBlk:\n");
    DISPTREE(*use);
    JITDUMP("\n");
#endif // FEATURE_SIMD
}

// Rewrite GT_OBJ of SIMD Vector as GT_IND(GT_LEA(obj.op1)) of a SIMD type.
//
// Arguments:
//    ppTree      - A pointer-to-a-pointer for the GT_OBJ
//    fgWalkData  - A pointer to tree walk data providing the context
//
// Return Value:
//    None.
//
// TODO-Cleanup: Once SIMD types are plumbed through the frontend, this will no longer
// be required.
//
void Rationalizer::RewriteObj(GenTree** use)
{    
#ifdef FEATURE_SIMD
    GenTreeObj* obj = (*use)->AsObj();

    // For UNIX struct passing, we can have Obj nodes for arguments.
    // For other cases, we should never see a non-SIMD type here.
#ifdef FEATURE_UNIX_AMD64_STRUCT_PASSING
    if (!varTypeIsSIMD(obj))
    {
        return;
    }
#endif // FEATURE_UNIX_AMD64_STRUCT_PASSING

    // Should come here only if featureSIMD is enabled
    noway_assert(comp->featureSIMD);

    // We should only call this with a SIMD type.
    noway_assert(varTypeIsSIMD(obj));
    var_types simdType = obj->TypeGet();

    // If the operand of obj is a GT_ADDR(GT_LCL_VAR) and LclVar is known to be a SIMD type,
    // replace obj by GT_LCL_VAR.
    GenTree* srcAddr = obj->gtGetOp1();
    if (srcAddr->OperGet() == GT_ADDR && comp->isSIMDTypeLocal(srcAddr->gtGetOp1()))
    {
        m_block->RemoveNode(srcAddr);
        m_block->RemoveNode(obj);

        GenTree* src = srcAddr->gtGetOp1();
        src->gtType = simdType;
        m_block->ReplaceUseWith(use, src);
    }
    else 
    {
        obj->SetOper(GT_IND);
        obj->gtType = simdType;
    }
#else
    // we should never reach without feature SIMD
    assert(!"Unexpected obj during rationalization\n");
    unreached();
#endif
}

// RewriteNodeAsCall : Replace the given tree node by a GT_CALL.
//
// Arguments:
//    ppTree      - A pointer-to-a-pointer for the tree node
//    fgWalkData  - A pointer to tree walk data providing the context
//    callHnd     - The method handle of the call to be generated
//    entryPoint  - The method entrypoint of the call to be generated
//    args        - The argument list of the call to be generated
//
// Return Value:
//    None.
//

void Rationalizer::RewriteNodeAsCall(GenTree** use, Compiler::fgWalkData* data,
    CORINFO_METHOD_HANDLE callHnd,
#ifdef FEATURE_READYTORUN_COMPILER
    CORINFO_CONST_LOOKUP entryPoint,
#endif
    GenTreeArgList* args)
{
    GenTreePtr tree = *use;
    Compiler*  comp = data->compiler;
    SplitData* tmpState = (SplitData *)data->pCallbackData;
    GenTreePtr root = tmpState->root;
    GenTreePtr treeFirstNode = comp->fgGetFirstNode(tree);
    GenTreePtr treeLastNode = tree;
    GenTreePtr treePrevNode = treeFirstNode->gtPrev;
    GenTreePtr treeNextNode = treeLastNode->gtNext;

    // Create the call node
    GenTreeCall* call = comp->gtNewCallNode(CT_USER_FUNC, callHnd, tree->gtType, args);
    call = comp->fgMorphArgs(call);
    call->CopyCosts(tree);
#ifdef FEATURE_READYTORUN_COMPILER
    call->gtCall.setEntryPoint(entryPoint);
#endif

    // Replace "tree" with "call"
    *use = call;
        
    // Rebuild the evaluation order.
    comp->gtSetStmtInfo(root);

    // Rebuild the execution order.
    comp->fgSetTreeSeq(call, treePrevNode);

    // Restore linear-order Prev and Next for "call".
    if (treePrevNode)
    {
        treeFirstNode = comp->fgGetFirstNode(call);
        treeFirstNode->gtPrev = treePrevNode;
        treePrevNode->gtNext = treeFirstNode;
    }
    else
    {
        // Update the linear oder start of "root" if treeFirstNode 
        // appears to have replaced the original first node.
        assert(treeFirstNode == root->gtStmt.gtStmtList);
        root->gtStmt.gtStmtList = comp->fgGetFirstNode(call);
    }

    if (treeNextNode)
    {
        treeLastNode = call;
        treeLastNode->gtNext = treeNextNode;
        treeNextNode->gtPrev = treeLastNode;
    }
    
    comp->fgFixupIfCallArg(data->parentStack, tree, call);

    // Propagate flags of "call" to its parents.
    // 0 is current node, so start at 1
    for (int i = 1; i < data->parentStack->Height(); i++)
    {
        GenTree *node = data->parentStack->Index(i);
        node->gtFlags |= GTF_CALL;
        node->gtFlags |= call->gtFlags & GTF_ALL_EFFECT;
    }

    // Since "tree" is replaced with "call", pop "tree" node (i.e the current node)
    // and replace it with "call" on parent stack.
    assert(data->parentStack->Top() == tree);
    (void)data->parentStack->Pop();
    data->parentStack->Push(call);

    DBEXEC(TRUE, ValidateStatement(root, tmpState->block));
}

// RewriteIntrinsicAsUserCall : Rewrite an intrinsic operator as a GT_CALL to the original method.
//
// Arguments:
//    ppTree      - A pointer-to-a-pointer for the intrinsic node
//    fgWalkData  - A pointer to tree walk data providing the context
//
// Return Value:
//    None.
//
// Some intrinsics, such as operation Sqrt, are rewritten back to calls, and some are not. 
// The ones that are not being rewritten here must be handled in Codegen.
// Conceptually, the lower is the right place to do the rewrite. Keeping it in rationalization is
// mainly for throughput issue.

void Rationalizer::RewriteIntrinsicAsUserCall(GenTree** use, Compiler::fgWalkData* data)
{
    GenTreeIntrinsic* intrinsic = (*use)->AsIntrinsic();
    Compiler* comp = data->compiler;

    GenTreeArgList* args;
    if (intrinsic->gtOp.gtOp2 == nullptr)
    {
        args = comp->gtNewArgList(intrinsic->gtGetOp1());
    }
    else
    {
        args = comp->gtNewArgList(intrinsic->gtGetOp1(), intrinsic->gtGetOp2());
    }

    RewriteNodeAsCall(use, data,
        intrinsic->gtMethodHandle,
#ifdef FEATURE_READYTORUN_COMPILER
        intrinsic->gtEntryPoint,
#endif
        args);
}

// FixupIfSIMDLocal: Fixup the type of a lclVar tree, as needed, if it is a SIMD type vector.
//
// Arguments:
//    comp      - the Compiler object.
//    tree      - the GenTreeLclVarCommon tree to be fixed up.
//
// Return Value:
//    None.
//
// TODO-Cleanup: Once SIMD types are plumbed through the frontend, this will no longer
// be required.

void Rationalizer::FixupIfSIMDLocal(GenTreeLclVarCommon* node)
{
#ifdef FEATURE_SIMD
    if (!comp->featureSIMD)
    {
        return;
    }

    LclVarDsc* varDsc = &(comp->lvaTable[node->gtLclNum]);

    // Don't mark byref of SIMD vector as a SIMD type.
    // Note that struct args though marked as lvIsSIMD=true,
    // the tree node representing such an arg should not be 
    // marked as a SIMD type, since it is a byref of a SIMD type.
    if (!varTypeIsSIMD(varDsc))
    {
        return;
    }
    switch(node->OperGet())
    {
    default:
        // Nothing to do for most tree nodes.
        break;

    case GT_LCL_FLD:
        // We may see a lclFld used for pointer-sized structs that have been morphed, in which
        // case we can change it to GT_LCL_VAR.
        // However, we may also see a lclFld with FieldSeqStore::NotAField() for structs that can't
        // be analyzed, e.g. those with overlapping fields such as the IL implementation of Vector<T>.
        if ((node->AsLclFld()->gtFieldSeq == FieldSeqStore::NotAField()) &&
            (node->AsLclFld()->gtLclOffs == 0)                           &&
            (node->gtType == TYP_I_IMPL)                                 && 
            (varDsc->lvExactSize == TARGET_POINTER_SIZE))
        {
            node->SetOper(GT_LCL_VAR);
            node->gtFlags &= ~(GTF_VAR_USEASG);
        }
        else
        {
            // If we access a field of a SIMD lclVar via GT_LCL_FLD, it cannot have been
            // independently promoted.
            assert(comp->lvaGetPromotionType(varDsc) != Compiler::PROMOTION_TYPE_INDEPENDENT);
            return;
        }
        break;
    case GT_STORE_LCL_FLD:
        assert(node->gtType == TYP_I_IMPL);
        node->SetOper(GT_STORE_LCL_VAR);
        node->gtFlags &= ~(GTF_VAR_USEASG);
        break;
    }
    unsigned simdSize = (unsigned int) roundUp(varDsc->lvExactSize, TARGET_POINTER_SIZE);
    node->gtType = comp->getSIMDTypeForSize(simdSize);
#endif // FEATURE_SIMD
}

#ifdef DEBUG

void Rationalizer::ValidateStatement(GenTree *tree, BasicBlock *block)
{
    assert(tree->gtOper == GT_STMT);
    DBEXEC(TRUE, JitTls::GetCompiler()->fgDebugCheckNodeLinks(block, tree));
}

// sanity checks that apply to all kinds of IR
void Rationalizer::SanityCheck()
{
    BasicBlock * block;
    foreach_block(comp, block)
    {
        for (GenTree* statement = block->bbTreeList;
             statement != nullptr;
             statement = statement->gtNext)
        {
            ValidateStatement(statement, block);

            for (GenTree *tree = statement->gtStmt.gtStmtList;
                 tree; 
                 tree = tree->gtNext)
            {
                // QMARK nodes should have been removed before this phase.
                assert(tree->OperGet() != GT_QMARK);

                if (tree->OperGet() == GT_ASG)
                {
                    if (tree->gtGetOp1()->OperGet() == GT_LCL_VAR)
                    {
                        assert(tree->gtGetOp1()->gtFlags & GTF_VAR_DEF);
                    }
                    else if (tree->gtGetOp2()->OperGet() == GT_LCL_VAR)
                    {
                        assert(!(tree->gtGetOp2()->gtFlags & GTF_VAR_DEF));
                    }
                }
            }
        }
    }
}

void Rationalizer::SanityCheckRational()
{
    // TODO-Cleanup : check that the tree is rational here
    // then do normal checks
    SanityCheck();
}

#endif // DEBUG

static void RewriteAssignmentIntoStoreLclCore(GenTreeOp* assignment, GenTree* location, GenTree* value, genTreeOps locationOp)
{
    assert(assignment != nullptr);
    assert(assignment->OperGet() == GT_ASG);
    assert(location != nullptr);
    assert(value != nullptr);

    genTreeOps storeOp = storeForm(locationOp);

#ifdef DEBUG
    JITDUMP("rewriting asg(%s, X) to %s(X)\n", GenTree::NodeName(locationOp), GenTree::NodeName(storeOp));
#endif // DEBUG

    assignment->SetOper(storeOp);
    GenTreeLclVarCommon* store = assignment->AsLclVarCommon();

    GenTreeLclVarCommon* var = location->AsLclVarCommon();
    store->SetLclNum(var->gtLclNum);
    store->SetSsaNum(var->gtSsaNum);

    if (locationOp == GT_LCL_FLD)
    {
        store->gtLclFld.gtLclOffs = var->gtLclFld.gtLclOffs;
        store->gtLclFld.gtFieldSeq = var->gtLclFld.gtFieldSeq;
    }

    copyFlags(store, var, GTF_LIVENESS_MASK);
    store->gtFlags &= ~GTF_REVERSE_OPS;

    store->gtType = var->TypeGet();
    store->gtOp1 = value;

    DISPNODE(store);
    JITDUMP("\n");
}

void Rationalizer::RewriteAssignmentIntoStoreLcl(GenTreeOp* assignment)
{
    assert(assignment != nullptr);
    assert(assignment->OperGet() == GT_ASG);

    GenTree* location = assignment->gtGetOp1();
    GenTree* value = assignment->gtGetOp2();

    RewriteAssignmentIntoStoreLclCore(assignment, location, value, location->OperGet());
}

void Rationalizer::RewriteAssignment(GenTree** use)
{
    assert(use != nullptr);

    GenTreeOp* assignment = (*use)->AsOp();
    assert(assignment->OperGet() == GT_ASG);

    GenTree* location = assignment->gtGetOp1();
    GenTree* value = assignment->gtGetOp2();

    genTreeOps locationOp = location->OperGet();
    switch (locationOp)
    {
    case GT_LCL_VAR:
    case GT_LCL_FLD:
    case GT_REG_VAR:
    case GT_PHI_ARG:
        RewriteAssignmentIntoStoreLclCore(assignment, location, value, locationOp);
        m_block->RemoveNode(location);
        break;

    case GT_IND:
        {
            GenTreeStoreInd* store = new(comp, GT_STOREIND) GenTreeStoreInd(location->TypeGet(), location->gtGetOp1(), value);

            store->gtFlags |= location->gtFlags & GTF_IND_FLAGS;
            if (assignment->IsReverseOp())
            {
                store->gtFlags |= GTF_REVERSE_OPS;
            }

            store->CopyCosts(assignment);

            // TODO: JIT dump

            // Remove the GT_IND node and replace the assignment node with the store
            m_block->RemoveNode(location);
            m_block->InsertNodeBefore(store, assignment);
            m_block->ReplaceUseWith(use, store);
            m_block->RemoveNode(assignment);
        }
        break;

    case GT_CLS_VAR:
        {
            location->SetOper(GT_CLS_VAR_ADDR);
            location->gtType = TYP_BYREF;

            assignment->SetOper(GT_STOREIND);

            // TODO: JIT dump
        }
        break;

    default:
        unreached();
        break;
    }
}

void Rationalizer::RewriteAddress(GenTree** use)
{
    assert(use != nullptr);

    GenTreeUnOp* address = (*use)->AsUnOp();
    assert(address->OperGet() == GT_ADDR);

    GenTree* location = address->gtGetOp1();
    genTreeOps locationOp = location->OperGet();

    if (location->IsLocal())
    {
        // We are changing the child from GT_LCL_VAR TO GT_LCL_VAR_ADDR.
        // Therefore gtType of the child needs to be changed to a TYP_BYREF
#ifdef DEBUG
        if (locationOp == GT_LCL_VAR)
        {
            JITDUMP("Rewriting GT_ADDR(GT_LCL_VAR) to GT_LCL_VAR_ADDR:\n");
        }
        else
        {
            assert(locationOp == GT_LCL_FLD);
            JITDUMP("Rewriting GT_ADDR(GT_LCL_FLD) to GT_LCL_FLD_ADDR:\n");
        }
#endif // DEBUG

        location->SetOper(addrForm(locationOp));
        location->gtType = TYP_BYREF;
        copyFlags(location, address, GTF_ALL_EFFECT);

        m_block->ReplaceUseWith(use, location);
        m_block->RemoveNode(address);
    }
    else if (locationOp == GT_CLS_VAR)
    {
        location->SetOper(GT_CLS_VAR_ADDR);
        location->gtType = TYP_BYREF;
        copyFlags(location, address, GTF_ALL_EFFECT);

        m_block->ReplaceUseWith(use, location);
        m_block->RemoveNode(address);

        JITDUMP("Rewriting GT_ADDR(GT_CLS_VAR) to GT_CLS_VAR_ADDR:\n");
    }
    else if (locationOp == GT_IND)
    {
        m_block->ReplaceUseWith(use, location->gtGetOp1());
        m_block->RemoveNode(location);
        m_block->RemoveNode(address);

        JITDUMP("Rewriting GT_ADDR(GT_IND(X)) to X:\n");
    }

    DISPTREE(*use);
    JITDUMP("\n");
}

Compiler::fgWalkResult Rationalizer::RewriteNode(GenTree** use, ArrayStack<GenTree*>& parentStack)
{
    assert(use != nullptr);

    GenTree* node = *use;

    // First, remove any preceeding GT_LIST nodes, which are not otherwise visited by the tree walk.
    for (GenTree* prev = node->gtPrev; prev != nullptr && prev->OperGet() == GT_LIST; prev = node->gtPrev)
    {
        m_block->RemoveNode(prev);
    }

    switch (node->OperGet())
    {
    case GT_ASG:
        RewriteAssignment(use);
        break;

    case GT_BOX:
        // GT_BOX at this level just passes through so get rid of it
        m_block->ReplaceUseWith(use, node->gtGetOp1());
        m_block->RemoveNode(node);
        break;

    case GT_ADDR:
        RewriteAddress(use);
        break;

    case GT_NOP:
        // fgMorph sometimes inserts NOP nodes between defs and uses
        // supposedly 'to prevent constant folding'. In this case, remove the
        // NOP.
        if (node->gtGetOp1() != nullptr)
        {
            m_block->ReplaceUseWith(use, node->gtGetOp1());
            m_block->RemoveNode(node);
        }
        break;

    case GT_COMMA:
        {
            // Commas are replaced with their right-hand side unless the RHS is a true NOP, in which case
            // they are replaced by their LHS.

            // TODO: drop range defined by LHS if it is side-effect-free.

            GenTree* replacement = node->gtGetOp2();
            if (replacement->IsNothingNode())
            {
                replacement = node->gtGetOp1();
            }

            m_block->ReplaceUseWith(use, replacement);
            m_block->RemoveNode(node);
        }
        break;

    case GT_ARGPLACE:
        // Remove argplace nodes from the LIR.
        m_block->RemoveNode(node);
        break;

#ifdef _TARGET_XARCH_
    case GT_CLS_VAR:
        {
            node->SetOper(GT_CLS_VAR_ADDR);
            node->gtType = TYP_BYREF;

            GenTree* ind = comp->gtNewOperNode(GT_IND, node->TypeGet(), node);
            ind->CopyCosts(node);

            m_block->InsertNodeAfter(ind, node);
            m_block->ReplaceUseWith(use, ind);

            // TODO: JIT dump
        }
        break;
#endif // _TARGET_XARCH_

    case GT_INTRINSIC:
        // Non-target intrinsics should have already been rewritten back into user calls.
        assert(Compiler::IsTargetIntrinsic(node->gtIntrinsic.gtIntrinsicId));
        break;

#ifdef FEATURE_SIMD
    case GT_INITBLK:
        RewriteInitBlk(use);
        break;

    case GT_COPYBLK:
        RewriteCopyBlk(use);
        break;

    case GT_OBJ:
        RewriteObj(use);
        break;

    case GT_LCL_FLD:
    case GT_STORE_LCL_FLD:
        FixupIfSIMDLocal(node->AsLclVar());
        break;

    case GT_STOREIND:
    case GT_IND:
        if (node->gtType == TYP_STRUCT)
        {
            GenTree* addr = node->AsIndir()->Addr();
            assert(addr->OperIsLocal() && addr->TypeGet() == TYP_BYREF);
            LclVarDsc* varDsc = &(comp->lvaTable[addr->AsLclVarCommon()->gtLclNum]);
            assert(varDsc->lvSIMDType);
            unsigned simdSize = (unsigned int) roundUp(varDsc->lvExactSize, TARGET_POINTER_SIZE);
            node->gtType = comp->getSIMDTypeForSize(simdSize);
        }
        break;

    case GT_SIMD:
        {
            noway_assert(comp->featureSIMD);
            GenTreeSIMD* simdNode = node->AsSIMD();
            unsigned simdSize = simdNode->gtSIMDSize;
            var_types simdType = comp->getSIMDTypeForSize(simdSize);

            // TODO-Cleanup: This is no-longer required once we plumb SIMD types thru front-end
            if (simdNode->gtType == TYP_I_IMPL && simdNode->gtSIMDSize == TARGET_POINTER_SIZE)
            {
                // This happens when it is consumed by a GT_RET_EXPR.
                // It can only be a Vector2f or Vector2i.
                assert(genTypeSize(simdNode->gtSIMDBaseType) == 4);
                simdNode->gtType = TYP_SIMD8;
            }
            else if (simdNode->gtType == TYP_STRUCT || varTypeIsSIMD(simdNode))
            {
                node->gtType = simdType;
            }

            // Certain SIMD trees require rationalizing.
            if (simdNode->gtSIMD.gtSIMDIntrinsicID == SIMDIntrinsicInitArray)
            {
                // Rewrite this as an explicit load.
                JITDUMP("Rewriting GT_SIMD array init as an explicit load:\n");
                unsigned int baseTypeSize = genTypeSize(simdNode->gtSIMDBaseType);
                GenTree* address = new (comp, GT_LEA) GenTreeAddrMode(TYP_BYREF, simdNode->gtOp1, simdNode->gtOp2, baseTypeSize,  offsetof(CORINFO_Array, u1Elems));
                GenTree* ind = comp->gtNewOperNode(GT_IND, simdType, address);
                address->CopyCosts(simdNode);
                ind->CopyCosts(simdNode);

                m_block->InsertNodeBefore(address, simdNode);
                m_block->InsertNodeBefore(ind, simdNode);
                m_block->ReplaceUseWith(use, ind);
                m_block->RemoveNode(simdNode);

                //DISPTREE(tmpState->root);
                //JITDUMP("\n");
            }
            else 
            {
                // This code depends on the fact that NONE of the SIMD intrinsics take vector operands
                // of a different width.  If that assumption changes, we will EITHER have to make these type
                // transformations during importation, and plumb the types all the way through the JIT,
                // OR add a lot of special handling here.
                GenTree* op1 = simdNode->gtGetOp1();
                if (op1 != nullptr && op1->gtType == TYP_STRUCT)
                {
                    op1->gtType = simdType;
                }

                GenTree* op2 = simdNode->gtGetOp2();
                if (op2 != nullptr && op2->gtType == TYP_STRUCT)
                {
                    op2->gtType = simdType;
                }
            }
        }
        break;
#endif // FEATURE_SIMD

    default:
        // Nothing to do for most nodes.
        break;
    }

    GenTree* newNode = *use;
    if (newNode != node)
    {
        comp->fgFixupIfCallArg(&parentStack, node, newNode);
    }

    return Compiler::WALK_CONTINUE;
}

void Rationalizer::DoPhase()
{
    DBEXEC(TRUE, SanityCheck());

    comp->compCurBB = NULL;
    comp->fgOrder = Compiler::FGOrderLinear;

    BasicBlock* firstBlock = comp->fgFirstBB;

    for (BasicBlock* block = comp->fgFirstBB; block != nullptr; block = block->bbNext)
    {
        // Establish the first and last nodes for the block. This is necessary in order for the LIR
        // utilities that hang off the BasicBlock type to work correctly.
        GenTreeStmt* firstStatement = block->firstStmt();
        if (firstStatement == nullptr)
        {
            // No statements in this block; skip it.
            continue;
        }

        GenTreeStmt* lastStatement = block->lastStmt();
        block->bbTreeList = firstStatement->gtStmtList;
        block->bbLastNode = lastStatement->gtStmtExpr;

        // Rewrite intrinsics that are not supported by the target back into user calls.
        // This needs to be done before the transition to LIR because it relies on the use
        // of fgMorphArgs, which is designed to operate on HIR. Once this is done for a
        // particular statement, link that statement's nodes into the current basic block.
        GenTree* lastNodeInPreviousStatement = nullptr;
        for (GenTreeStmt* statement = firstStatement; statement != nullptr; statement = statement->getNextStmt())
        {
            assert(statement->gtStmtList != nullptr);
            assert(statement->gtStmtExpr != nullptr);

            SplitData splitData;
            splitData.root = statement;
            splitData.block = block;
            splitData.thisPhase = this;

            comp->fgWalkTreePost(&statement->gtStmtExpr,
                [](GenTree** use, Compiler::fgWalkData* walkData) -> Compiler::fgWalkResult
                {
                    GenTree* node = *use;
                    if (node->OperGet() == GT_INTRINSIC &&
                        Compiler::IsIntrinsicImplementedByUserCall(node->gtIntrinsic.gtIntrinsicId))
                    {
                        RewriteIntrinsicAsUserCall(use, walkData);

                        walkData->compiler->fgFixupIfCallArg(walkData->parentStack, node, *use);
                    }

                    return Compiler::WALK_CONTINUE;
                },
                &splitData,
                true);

            GenTree* firstNodeInStatement = statement->gtStmtList;
            if (lastNodeInPreviousStatement != nullptr)
            {
                lastNodeInPreviousStatement->gtNext = firstNodeInStatement;
            }

            firstNodeInStatement->gtPrev = lastNodeInPreviousStatement;
            lastNodeInPreviousStatement = statement->gtStmtExpr;
        }

        // Rewrite HIR nodes into LIR nodes.
        m_block = block;
        for (GenTreeStmt* statement = firstStatement, *nextStatement; statement != nullptr; statement = nextStatement)
        {
            nextStatement = statement->getNextStmt();

            // Change this statement into an IL offset node and insert it into the LIR.
            statement->SetOper(GT_IL_OFFSET);
            statement->gtNext = nullptr;
            statement->gtPrev = nullptr;

            block->InsertNodeBefore(statement, statement->gtStmtList);

            m_statement = statement;
            comp->fgWalkTreePost(&statement->gtStmtExpr,
                [](GenTree** use, Compiler::fgWalkData* walkData) -> Compiler::fgWalkResult
                {
                    return reinterpret_cast<Rationalizer*>(walkData->pCallbackData)->RewriteNode(use, *walkData->parentStack);
                },
                this,
                true);
        }
    }

    //DBEXEC(TRUE, SanityCheckRational());

    comp->compRationalIRForm = true;

    NYI("later stages cannot yet process LIR!");
}
