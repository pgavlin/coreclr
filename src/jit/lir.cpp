// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#include "jitpch.h"
#ifdef _MSC_VER
#pragma hdrstop
#endif

LIR::Use::Use()
    : m_range(nullptr)
    , m_edge(nullptr)
    , m_user(nullptr)
{
}

LIR::Use::Use(const Use& other)
{
    *this = other;
}

//------------------------------------------------------------------------
// LIR::Use::Use: Constructs a use <-> def edge given the range that
//                contains the use and the def, the use -> def edge, and
//                the user.
//
// Arguments:
//    range - The range that contains the use and the def.
//    edge - The use -> def edge.
//    user - The node that uses the def.
//
// Return Value:
//
LIR::Use::Use(Range& range, GenTree** edge, GenTree* user)
    : m_range(&range)
    , m_edge(edge)
    , m_user(user)
{
#if DEBUG
    assert(range.ContainsNode(user));

    GenTree** userEdge;
    bool foundUse = user->TryGetUse(*edge, &userEdge);
    assert(foundUse);
    assert(userEdge == edge);

    assert(IsValid());
#endif
}

LIR::Use& LIR::Use::operator=(const Use& other)
{
    m_range = other.m_range;
    m_user = other.m_user;
    m_edge = other.IsDummyUse() ? &m_user : other.m_edge;

    assert(IsDummyUse() == other.IsDummyUse());
    return *this;
}

LIR::Use& LIR::Use::operator=(Use&& other)
{
    *this = other;
    return *this;
}

//------------------------------------------------------------------------
// LIR::Use::GetDummyUse: Returns a dummy use for a node.
//
// This method is provided as a convenience to allow transforms to work
// uniformly over Use values. It allows the creation of a Use given a node
// that is not used.
//
// Arguments:
//    range - The range that contains the node.
//    node - The node for which to create a dummy use.
//
// Return Value:
//
LIR::Use LIR::Use::GetDummyUse(Range& range, GenTree* node)
{
    assert(node != nullptr);

    Use dummyUse;
    dummyUse.m_range = &range;
    dummyUse.m_user = node;
    dummyUse.m_edge = &dummyUse.m_user;

    assert(dummyUse.IsValid());
    return dummyUse;
}

//------------------------------------------------------------------------
// LIR::Use::IsDummyUse: Indicates whether or not a use is a dummy use.
//
// This method must be called before attempting to call the User() method
// below: for dummy uses, the user is the same node as the def.
//
// Return Value: true if this use is a dummy use; false otherwise.
//
bool LIR::Use::IsDummyUse() const
{
    return m_edge == &m_user;
}

//------------------------------------------------------------------------
// LIR::Use::Def: Returns the node that produces the def for this use.
//
GenTree* LIR::Use::Def() const
{
    assert(IsValid());

    return *m_edge;
}

//------------------------------------------------------------------------
// LIR::Use::User: Returns the node that uses the def for this use.
///
GenTree* LIR::Use::User() const
{
    assert(IsValid());
    assert(!IsDummyUse());

    return m_user;
}

//------------------------------------------------------------------------
// LIR::Use::IsValid: Returns true if the use is valid; false otherwise.
//
bool LIR::Use::IsValid() const
{
    return (m_range != nullptr) && (m_edge != nullptr) && (m_user != nullptr);
}

//------------------------------------------------------------------------
// LIR::Use::ReplaceWith: Changes the use to point to a new value.
//
// For example, given the following LIR:
//
//    t15 =    lclVar    int    arg1
//    t16 =    lclVar    int    arg1
//
//          /--*  t15 int
//          +--*  t16 int
//    t17 = *  ==        int
//
//          /--*  t17 int
//          *  jmpTrue   void
//
// If we wanted to replace the use of t17 with a use of the constant "1", we
// might do the following (where `opEq` is a `Use` value that represents the
// use of t17):
//
//    GenTree* constantOne = compiler->gtNewIconNode(1);
//    range.InsertAfter(constantOne, opEq.Def());
//    opEq.ReplaceWith(compiler, constantOne);
//
// Which would produce something like the following LIR:
//
//    t15 =    lclVar    int    arg1
//    t16 =    lclVar    int    arg1
//
//          /--*  t15 int
//          +--*  t16 int
//    t17 = *  ==        int
//
//    t18 =    const     int    1
//
//          /--*  t18 int
//          *  jmpTrue   void
//
// Elminating the now-dead compare and its operands using `LIR::Range::Remove`
// would then give us:
//
//    t18 =    const     int    1
//
//          /--*  t18 int
//          *  jmpTrue   void
//
// Arguments:
//    compiler - The Compiler context.
//    replacement - The replacement node.
//
void LIR::Use::ReplaceWith(Compiler* compiler, GenTree* replacement)
{
    assert(IsValid());
    assert(compiler != nullptr);
    assert(replacement != nullptr);
    assert(IsDummyUse() || m_range->ContainsNode(m_user));
    assert(m_range->ContainsNode(replacement));

    GenTree* replacedNode = *m_edge;

    *m_edge = replacement;
    if (!IsDummyUse() && m_user->IsCall())
    {
        compiler->fgFixupArgTabEntryPtr(m_user, replacedNode, replacement);
    }
}

//------------------------------------------------------------------------
// LIR::Use::ReplaceWithLclVar: Assigns the def for this use to a local
//                              var and points the use to a use of that
//                              local var. If no local number is provided,
//                              creates a new local var.
//
// For example, given the following IR:
//
//    t15 =    lclVar    int    arg1
//    t16 =    lclVar    int    arg1
//
//          /--*  t15 int
//          +--*  t16 int
//    t17 = *  ==        int
//
//          /--*  t17 int
//          *  jmpTrue   void
//
// If we wanted to replace the use of t17 with a use of a new local var
// that holds the value represented by t17, we might do the following
// (where `opEq` is a `Use` value that represents the use of t17):
//
//    opEq.ReplaceUseWithLclVar(compiler, block->getBBWeight(compiler));
//
// This would produce the following LIR:
//
//    t15 =    lclVar    int    arg1
//    t16 =    lclVar    int    arg1
//
//          /--*  t15 int
//          +--*  t16 int
//    t17 = *  ==        int
//
//          /--*  t17 int
//          *  st.lclVar int    tmp0
//
//    t18 =    lclVar    int    tmp0
//
//          /--*  t18 int
//          *  jmpTrue   void
//
// Arguments:
//    compiler - The Compiler context.
//    blockWeight - The weight of the basic block that contains the use.
//    lclNum - The local to use for temporary storage. If BAD_VAR_NUM (the
//             default) is provided, this method will create and use a new
//             local var.
//
// Return Value: The number of the local var used for temporary storage.
//
unsigned LIR::Use::ReplaceWithLclVar(Compiler* compiler, unsigned blockWeight, unsigned lclNum)
{
    assert(IsValid());
    assert(compiler != nullptr);
    assert(m_range->ContainsNode(m_user));
    assert(m_range->ContainsNode(*m_edge));

    GenTree* node = *m_edge;

    if (lclNum == BAD_VAR_NUM)
    {
        lclNum = compiler->lvaGrabTemp(true DEBUGARG("ReplaceWithLclVar is creating a new local variable"));
    }

    // Increment its lvRefCnt and lvRefCntWtd twice, one for the def and one for the use
    compiler->lvaTable[lclNum].incRefCnts(blockWeight, compiler);
    compiler->lvaTable[lclNum].incRefCnts(blockWeight, compiler);

    GenTreeLclVar* store = compiler->gtNewTempAssign(lclNum, node)->AsLclVar();
    m_range->InsertAfter(store, node);

    GenTree* load = new (compiler, GT_LCL_VAR) GenTreeLclVar(store->TypeGet(), store->AsLclVarCommon()->GetLclNum(), BAD_IL_OFFSET);
    m_range->InsertAfter(load, store);

    ReplaceWith(compiler, load);

    JITDUMP("ReplaceWithLclVar created store :\n");
    DISPTREE(store);

    return lclNum;
}

LIR::Range::Range()
    : m_firstNodeSlot(nullptr)
    , m_lastNodeSlot(nullptr)
{
}

//------------------------------------------------------------------------
// LIR::Range::Range: Creates a `Range` value given two locations that
//                    store the first and last node in the range.
//
// Arguments:
//    firstNodeSlot - The storage for the first node in the range.
//    lastNodeSlot - The storage for the last node in the range.
//
LIR::Range::Range(GenTree** firstNodeSlot, GenTree** lastNodeSlot)
    : m_firstNodeSlot(firstNodeSlot)
    , m_lastNodeSlot(lastNodeSlot)
{
    assert(firstNodeSlot != nullptr);
    assert(lastNodeSlot != nullptr);
    assert(firstNodeSlot != lastNodeSlot);

    assert((FirstNode() != nullptr) == (LastNode() != nullptr));
    assert((FirstNode() == LastNode()) || FirstNode()->Precedes(LastNode()));
}

//------------------------------------------------------------------------
// LIR::Range::FirstNode: Returns a reference to the first node in the
//                        range.
//
// Note: this method is private because it allows the caller to
// subsequently modify the value stored in `m_firstNodeSlot`.
//
GenTree*& LIR::Range::FirstNode() const
{
    assert(m_firstNodeSlot != nullptr);
    return *m_firstNodeSlot;
}

//------------------------------------------------------------------------
// LIR::Range::LastNode: Returns a reference to the last node in the
//                       range.
// Note: this method is private because it allows the caller to
// subsequently modify the value stored in `m_lastNodeSlot`.
//
GenTree*& LIR::Range::LastNode() const
{
    assert(m_lastNodeSlot != nullptr);
    return *m_lastNodeSlot;
}

//------------------------------------------------------------------------
// LIR::Range::IsValid: Returns true if the `Range` value is valid.
//
// A `Range` is considered valid for the purposes of this method if its
// storage has been initialized and it is either empty or has non-null
// values for its first and last node. This method does not check whether
// or not the first and last nodes actually define a range.
//
// Arguments:
//
// Return Value:
//
bool LIR::Range::IsValid() const
{
    return (m_firstNodeSlot != nullptr) && (m_lastNodeSlot != nullptr) && 
        (IsEmpty() || ((FirstNode() != nullptr) && (LastNode() != nullptr)));
}

//------------------------------------------------------------------------
// LIR::Range::IsEmpty: Returns true if the range is empty; false
//                      otherwise.
//
bool LIR::Range::IsEmpty() const
{
    return FirstNode() == nullptr;
}

//------------------------------------------------------------------------
// LIR::Range::IsSubRange: Returns true if the range is a subsequence of
//                         another range; false otherwise.
//
bool LIR::Range::IsSubRange() const
{
    return !IsEmpty() && ((FirstNode()->gtPrev != nullptr) || (LastNode()->gtNext != nullptr));
}

//------------------------------------------------------------------------
// LIR::Range::Begin: Returns the first node in the range.
//
GenTree* LIR::Range::Begin() const
{
    return FirstNode();
}

//------------------------------------------------------------------------
// LIR::Range::End: Returns a value that can be used during iteration to
//                  find the end of the range. Note that this value is not
//                  the last node in the range; rather, it is the node
//                  that follows the last node or null.
//
GenTree* LIR::Range::End() const
{
    return IsEmpty() ? nullptr : LastNode()->gtNext;
}

//------------------------------------------------------------------------
// LIR::Range::begin: Returns an iterator positioned at the first node in
//                    the range.
//
LIR::Range::Iterator LIR::Range::begin() const
{
    return Iterator(Begin());
}

//------------------------------------------------------------------------
// LIR::Range::end: Returns an iterator positioned at the last node in the
//                  range.
//
LIR::Range::Iterator LIR::Range::end() const
{
    return Iterator(End());
}


//------------------------------------------------------------------------
// LIR::Range::FirstNonPhiNode: Returns the first non-phi node in the
//                              range.
//
GenTree* LIR::Range::FirstNonPhiNode() const
{
    assert(IsValid());

    for (GenTree* node : *this)
    {
        if ((node->OperGet() != GT_PHI_ARG) && (node->OperGet() != GT_PHI) && !node->IsPhiDefn())
        {
            return node;
        }
    }

    return End();
}

//------------------------------------------------------------------------
// LIR::Range::InsertBefore: Inserts a node before another node in this
//                           range.
//
// Arguments:
//    node - The node to insert. Must not be part of any range.
//    insertionPoint - The node before which `node` will be inserted.
//                     Must be part of this range.
//
void LIR::Range::InsertBefore(GenTree* node, GenTree* insertionPoint)
{
    assert(node != nullptr);
    assert(node->gtPrev == nullptr);
    assert(node->gtNext == nullptr);

    if (insertionPoint == nullptr)
    {
        assert(FirstNode() == nullptr);
        assert(LastNode() == nullptr);

        FirstNode() = node;
        return;
    }

    assert(ContainsNode(insertionPoint));

    node->gtPrev = insertionPoint->gtPrev;
    if (node->gtPrev != nullptr)
    {
        node->gtPrev->gtNext = node;
    }
    else
    {
        assert(insertionPoint == FirstNode());
        FirstNode() = node;
    }

    node->gtNext = insertionPoint;
    insertionPoint->gtPrev = node;
}

//------------------------------------------------------------------------
// LIR::Range::InsertAfter: Inserts a node after another node in this
//                          range.
//
// Arguments:
//    node - The node to insert. Must not be part of any range.
//    insertionPoint - The node after which `node` will be inserted.
//                     Must be part of this range.
//
void LIR::Range::InsertAfter(GenTree* node, GenTree* insertionPoint)
{
    assert(node != nullptr);
    assert(node->gtPrev == nullptr);
    assert(node->gtNext == nullptr);

    if (insertionPoint == nullptr)
    {
        assert(FirstNode() == nullptr);
        assert(LastNode() == nullptr);

        FirstNode() = node;
        return;
    }

    assert(ContainsNode(insertionPoint));

    node->gtNext = insertionPoint->gtNext;
    if (node->gtNext != nullptr)
    {
        node->gtNext->gtPrev = node;
    }
    else
    {
        assert(insertionPoint == LastNode());
        LastNode() = node;
    }

    node->gtPrev = insertionPoint;
    insertionPoint->gtNext = node;
}

//------------------------------------------------------------------------
// LIR::Range::Remove: Removes a node from this range.
//
// Arguments:
//    node - The node to remove. Must be part of this range.
//
void LIR::Range::Remove(GenTree* node)
{
    assert(node != nullptr);
    assert(ContainsNode(node));

    GenTree* prev = node->gtPrev;
    GenTree* next = node->gtNext;

    if (prev != nullptr)
    {
        prev->gtNext = next;
    }
    else
    {
        assert(node == FirstNode());
        FirstNode() = next;
    }

    if (next != nullptr)
    {
        next->gtPrev = prev;
    }
    else
    {
        assert(node == LastNode());
        LastNode() = prev;
    }

    node->gtPrev = nullptr;
    node->gtNext = nullptr;
}

//------------------------------------------------------------------------
// LIR::Range::TryGetUse: Try to find the use for a given node.
//
// Arguments:
//    node - The node for which to find the corresponding use.
//    use (out) - The use of the corresponding node, if any. Invalid if
//                this method returns false.
//
// Return Value: Returns true if a use was found; false otherwise.
//
bool LIR::Range::TryGetUse(GenTree* node, Use* use)
{
    assert(node != nullptr);
    assert(use != nullptr);
    assert(ContainsNode(node));

    // Don't bother looking for uses of nodes that are not values.
    if (node->IsValue())
    {
        for (GenTree* n : LIR::AsRange(node->gtNext, End()))
        {
            GenTree** edge;
            if (n->TryGetUse(node, &edge))
            {
                *use = Use(*this, edge, n);
                return true;
            }
        }
    }

    *use = Use();
    return false;
}

#ifdef DEBUG

//------------------------------------------------------------------------
// LIR::Range::ContainsNode: Indicates whether or not this range contains
//                           a given node.
//
// Arguments:
//    node - The node to find.
//
// Return Value: True if this range contains the given node; false
//               otherwise.
//
bool LIR::Range::ContainsNode(GenTree* node) const
{
    assert(node != nullptr);

    for (GenTree* n : *this)
    {
        if (n == node)
        {
            return true;
        }
    }

    return false;
}

//------------------------------------------------------------------------
// LIR::Range::CheckLIR: Performs a set of correctness checks on the LIR
//                       contained in this range.
//
// This method checks the following properties:
// - Defs are singly-used
// - Uses follow defs
// - Uses are correctly linked into the block
// - Nodes that do not produce values are not used
// - Only LIR nodes are present in the block
// - If any phi nodes are present in the range, they precede all other
//   nodes
//
// The first four properties are verified by walking the block's LIR in execution order,
// inserting defs into a set as they are visited, and removing them as they are used. The
// different cases are distinguished only when an error is detected.
//
// Arguments:
//    compiler - A compiler context.
//
// Return Value:
//
bool LIR::Range::CheckLIR(Compiler* compiler) const
{
    // The check that uses are correctly linked into this range may fail
    // erroneously if this range is a sub-range.
    assert(!IsSubRange());

    // This code uses a stack as a map. Lookup is accomplished by scanning downward from the top.
    // This relies on defs being near uses for efficiency.
    ArrayStack<GenTree*> unusedDefs(compiler);
    auto recordDef = [&unusedDefs](GenTree* def)
    {
        unusedDefs.Push(def);
    };

    auto tryConsumeDef = [&unusedDefs](GenTree* def) -> bool
    {
        int height = unusedDefs.Height();
        for (int i = 0; i < height; i++)
        {
            if (unusedDefs.Index(i) == def)
            {
                for (; i > 0; i--)
                {
                    unusedDefs.IndexRef(i) = unusedDefs.Index(i - 1);
                }

                unusedDefs.Pop();
                return true;
            }
        }

        return false;
    };

    bool pastPhis = false;
    GenTree* prev = nullptr;
    for (Iterator node = begin(), end = this->end(); node != end; prev = *node, ++node)
    {
        // Verify that the node is allowed in LIR.
        assert(node->IsLIR());

        // Check that all phi nodes (if any) occur at the start of the range.
        if ((node->OperGet() == GT_PHI_ARG) || (node->OperGet() == GT_PHI) || node->IsPhiDefn())
        {
            assert(!pastPhis);
        }
        else
        {
            pastPhis = true;
        }

        // Skip nodes that do not produce values.
        if (!node->IsValue())
        {
            continue;
        }

        unsigned numOperands = node->NumOperands();
        for (unsigned i = 0; i < numOperands; i++)
        {
            GenTree** use = node->GetOperand(i);
            GenTree* def = *use;
            if (def->OperGet() == GT_ARGPLACE)
            {
                // ARGPLACE nodes are not represented in the LIR sequence. Ignore them.
                continue;
            }
            else if (!def->IsValue())
            {
                // Calls may contain "uses" of nodes that do not produce a value. This is an artifact of
                // the HIR and should probably be fixed, but doing so is an unknown amount of work.
                assert(node->OperGet() == GT_CALL);
                continue;
            }

            bool foundDef = tryConsumeDef(def);
            if (!foundDef)
            {
                // First, scan backwards and look for a preceding use.
                for (GenTree* prev = *node; prev != nullptr; prev = prev->gtPrev)
                {
                    // TODO: dump the users and the def
                    GenTree** earlierUse;
                    bool foundEarlierUse = prev->TryGetUse(def, &earlierUse) && earlierUse != use;
                    assert(!foundEarlierUse && "found multiply-used LIR node");
                }

                // The def did not precede the use. Check to see if it exists in the block at all.
                for (GenTree* next = node->gtNext; next != nullptr; next = next->gtNext)
                {
                    // TODO: dump the user and the def
                    assert(next != def && "found def after use");
                }

                // The def might not be a node that produces a value.
                assert(def->IsValue() && "found use of a node that does not produce a value");

                // By this point, the only possibility is that the def is not threaded into the LIR sequence.
                assert(false && "found use of a node that is not in the LIR sequence");
            }
        }

        recordDef(*node);
    }

    assert(prev == LastNode());

    return true;
}

#endif // DEBUG

//------------------------------------------------------------------------
// LIR::SimpleRange::SimpleRange: Constructs a range given a first and
//                                last node.
//
// Arguments:
//    firstNode - The first node in the range. Must precede lastNode.
//    lastNode - The last node in the range. Must follow firstNode.
//
LIR::SimpleRange::SimpleRange(GenTree* firstNode, GenTree* lastNode)
    : Range(&m_firstNode, &m_lastNode)
    , m_firstNode(firstNode)
    , m_lastNode(lastNode)
{
    assert((firstNode == nullptr) == (lastNode == nullptr));
    assert((FirstNode() == LastNode()) || FirstNode()->Precedes(LastNode()));
}

//------------------------------------------------------------------------
// LIR::EmptyRange: Constructs and returns an empty range.
//
LIR::Range LIR::EmptyRange()
{
    return SimpleRange(nullptr, nullptr);
}

//------------------------------------------------------------------------
// LIR::AsRange: Constructs and returns a range given a first and last
//               node.
//
// Arguments:
//    firstNode - The first node in the range. Must precede lastNode.
//    lastNode - The last node in the range. Must follow firstNode.
//
LIR::Range LIR::AsRange(GenTree* firstNode, GenTree* lastNode)
{
    return SimpleRange(firstNode, lastNode);
}
