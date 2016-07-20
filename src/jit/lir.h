// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#ifndef _LIR_H_
#define _LIR_H_

class Compiler;
struct GenTree;

class LIR final
{
public:
    class Range;

    //------------------------------------------------------------------------
    // LIR::Use: Represents a use <-> def edge between two nodes in a range
    //           of LIR. Provides utilities to point the use to a different
    //           def.
    //
    class Use final
    {
    private:
        Range* m_range;
        GenTree** m_edge;
        GenTree* m_user;


    public:
        Use();
        Use(const Use& other);
        Use(Range& range, GenTree** edge, GenTree* user);

        Use& operator=(const Use& other);
        Use& operator=(Use&& other);

        static Use GetDummyUse(Range& range, GenTree* node);

        GenTree* Def() const;
        GenTree* User() const;

        bool IsValid() const;
        bool IsDummyUse() const;

        void ReplaceWith(Compiler* compiler, GenTree* replacement);
        unsigned ReplaceWithLclVar(Compiler* compiler, unsigned blockWeight, unsigned lclNum = BAD_VAR_NUM);
    };

    //------------------------------------------------------------------------
    // LIR::Range: Represents a contiguous range of LIR nodes. Provides a
    //             variety of utilites that modify the LIR contained in the
    //             range.
    //
    class Range
    {
        friend class LIR;
        friend class SimpleRange;

    private:
        GenTree** m_firstNodeSlot;
        GenTree** m_lastNodeSlot;

        Range(GenTree** firstNodeSlot, GenTree** lastNodeSlot);

        GenTree*& FirstNode() const;
        GenTree*& LastNode() const;

    public:
        Range();

        GenTree* Begin() const;
        GenTree* End() const;

        bool IsValid() const;
        bool IsEmpty() const;
        bool IsSubRange() const;

        GenTree* FirstNonPhiNode() const;

        void InsertBefore(GenTree* node, GenTree* insertionPoint);
        void InsertAfter(GenTree* node, GenTree* insertionPoint);
        void Remove(GenTree* node);

        bool TryGetUse(GenTree* node, Use* use);

#ifdef DEBUG
        bool ContainsNode(GenTree* node) const;
        bool CheckLIR(Compiler* compiler) const;
#endif
    };

private:
    //------------------------------------------------------------------------
    // LIR::SimpleRange: Provides storage for a simple range defined only by
    //                   a start and end node. Can be used in order to
    //                   incrementally build up a range of IR to be inserted
    //                   into another range.
    //
    class SimpleRange final : public Range
    {
    private:
        GenTree* m_firstNode;
        GenTree* m_lastNode;

    public:
        SimpleRange(GenTree* firstNode, GenTree* lastNode);
    };

public:
    static Range EmptyRange();
    static Range AsRange(GenTree* firstNode, GenTree* lastNode);

    //------------------------------------------------------------------------
    // LIR::AsRange: Constructs and returns an LIR::Range value given a value
    //               of a type that provides the storage for the first and
    //               last nodes of the range.
    //
    // TContainer must implement the folliwing methods:
    //    GenTree** TContainer::FirstLIRNodeSlot();
    //    GenTree** TContainer::LastLIRNodeSlot();
    //
    // Arguments:
    //    container - The value that will provide the storage for the range's
    //                first and last nodes.
    //
    // Return Value: The newly constructed range.
    //
    template<typename TContainer>
    static Range AsRange(TContainer& container)
    {
        return Range(container->FirstLIRNodeSlot(), container->LastLIRNodeSlot());
    }

    //------------------------------------------------------------------------
    // LIR::AsRange: See the overload of AsRange() above. This overload
    //               accepts a pointer-typed argument so that the `this`
    //               parameter of a calling member method can be provided as
    //               the argument to `container`.
    //
    template<typename TContainer>
    static Range AsRange(TContainer* container)
    {
        return Range(container->FirstLIRNodeSlot(), container->LastLIRNodeSlot());
    }
};

#endif // _LIR_H_
