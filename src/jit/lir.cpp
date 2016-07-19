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

bool LIR::Use::IsDummyUse() const
{
    assert(IsValid());

    return m_edge == &m_user;
}

GenTree* LIR::Use::Def() const
{
    assert(IsValid());

    return *m_edge;
}

GenTree* LIR::Use::User() const
{
    assert(IsValid());

    return m_user;
}

bool LIR::Use::IsValid() const
{
    return (m_range != nullptr) && (m_edge != nullptr) && (m_user != nullptr);
}

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

LIR::Range::Range(GenTree** firstNodeSlot, GenTree** lastNodeSlot)
    : m_firstNodeSlot(firstNodeSlot)
    , m_lastNodeSlot(lastNodeSlot)
{
    assert(firstNodeSlot != nullptr);
    assert(lastNodeSlot != nullptr);
    assert(firstNodeSlot != lastNodeSlot);

    assert(FirstNode() != nullptr);
    assert(LastNode() != nullptr);

    assert((FirstNode() == LastNode()) || FirstNode()->Precedes(LastNode()));
}

GenTree*& LIR::Range::FirstNode() const
{
    assert(m_firstNodeSlot != nullptr);
    return *m_firstNodeSlot;
}

GenTree*& LIR::Range::LastNode() const
{
    assert(m_lastNodeSlot != nullptr);
    return *m_lastNodeSlot;
}

bool LIR::Range::IsValid() const
{
    return (m_firstNodeSlot != nullptr) && (m_lastNodeSlot != nullptr) && 
        (IsEmpty() || ((FirstNode() != nullptr) && (LastNode() != nullptr)));
}

bool LIR::Range::IsEmpty() const
{
    return FirstNode() == nullptr;
}

bool LIR::Range::IsSubRange() const
{
    return !IsEmpty() && ((FirstNode()->gtPrev != nullptr) || (LastNode()->gtNext != nullptr));
}

GenTree* LIR::Range::Start() const
{
    return FirstNode();
}

GenTree* LIR::Range::End() const
{
    return LastNode();
}

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

bool LIR::Range::TryGetUse(GenTree* node, Use* use)
{
    assert(node != nullptr);
    assert(use != nullptr);
    assert(ContainsNode(node));

    GenTree** edge;
    for (GenTree* n = node->gtNext; n != nullptr; n = n->gtNext)
    {
        if (n->TryGetUse(node, &edge))
        {
            *use = Use(*this, edge, n);
            return true;
        }
    }

    *use = Use();
    return false;
}

#ifdef DEBUG
bool LIR::Range::ContainsNode(GenTree* node) const
{
    assert(node != nullptr);

    for (GenTree* n = FirstNode(); n != nullptr; n = n->gtNext)
    {
        if (n == node)
        {
            return true;
        }
    }

    return false;
}

bool LIR::Range::CheckLIR(Compiler* compiler) const
{
    // Debug checks:
    // - defs are singly-used
    // - uses follow defs
    // - uses are correctly linked into the block
    // - nodes that do not produce values are not used
    // - only LIR nodes are present in the block
    //
    // The first four properties are verified by walking the block's LIR in execution order,
    // inserting defs into a set as they are visited, and removing them as they are used. The
    // different cases are distinguished only when an error is detected.
    //
    // The final property is verified simply by checking the opcode for each node as it is
    // visited.

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

    GenTree* prev = nullptr;
    for (GenTree* node = FirstNode(); node != nullptr; prev = node, node = node->gtNext)
    {
        // Verify that the node is allowed in LIR.
        assert(node->IsLIR());

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
                for (GenTree* prev = node; prev != nullptr; prev = prev->gtPrev)
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

                // By this point, the only possibility is that the def is not threaded into the LIR sequence.
                assert(false && "found use of a node that is not in the LIR sequence");
            }
        }

        recordDef(node);
    }

    return true;
}

LIR::SimpleRange::SimpleRange(GenTree* firstNode, GenTree* lastNode)
    : Range(&m_firstNode, &m_lastNode)
    , m_firstNode(firstNode)
    , m_lastNode(lastNode)
{
    assert((firstNode == nullptr) == (lastNode == nullptr));
    assert((FirstNode() == LastNode()) || FirstNode()->Precedes(LastNode()));
}

LIR::Range LIR::EmptyRange()
{
    return SimpleRange(nullptr, nullptr);
}

LIR::Range LIR::AsRange(GenTree* firstNode, GenTree* lastNode)
{
    return SimpleRange(firstNode, lastNode);
}

#endif // DEBUG
