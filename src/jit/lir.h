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
    // LIR::Flags: Defines the set of flags that may appear in the
    //             GenTree::gtLIRFlags field.
    class Flags final
    {
        // Disallow the creation of values of this type.
        Flags() = delete;

    public:
        enum : unsigned char
        {
            None = 0x00,
            Mark = 0x01, // An aribtrary "mark" bit that can be used in place of
                         // a more expensive data structure when processing a set
                         // of LIR nodes. See for example `LIR::GetTreeRange`.
        };
    };

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

        bool IsInitialized() const;
        void AssertIsValid() const;
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
        bool m_isSimpleRange;      // A simple range provides its own storage: instead of holding
                                   // pointers to the first and last node tracked by some other
                                   // container, `m_firstNodeSlot` and `m_lastNodeSlot` hold pointers
                                   // to the first and last node in the range, respectively.

        Range(GenTree** firstNodeSlot, GenTree** lastNodeSlot);
        Range(GenTree* firstNode, GenTree* lastNode);

        GenTree*& FirstNode() const;
        GenTree*& LastNode() const;

        Range GetMarkedRange(unsigned markCount, GenTree* start, bool* isClosed, unsigned* sideEffects) const;

    public:
        class Iterator
        {
            friend class Range;

            GenTree* m_node;

            Iterator(GenTree* begin)
                : m_node(begin)
            {
            }

        public:
            Iterator()
                : m_node(nullptr)
            {
            }

            inline GenTree* operator*()
            {
                return m_node;
            }

            inline GenTree* operator->()
            {
                return m_node;
            }

            inline bool operator==(const Iterator& other) const
            {
                return m_node == other.m_node;
            }

            inline bool operator!=(const Iterator& other) const
            {
                return m_node != other.m_node;
            }

            inline Iterator& operator++()
            {
                m_node = (m_node == nullptr) ? nullptr : m_node->gtNext;
                return *this;
            }
        };

        class ReverseIterator
        {
            friend class Range;

            GenTree* m_node;

            ReverseIterator(GenTree* begin)
                : m_node(begin)
            {
            }

        public:
            ReverseIterator()
                : m_node(nullptr)
            {
            }

            inline GenTree* operator*()
            {
                return m_node;
            }

            inline GenTree* operator->()
            {
                return m_node;
            }

            inline bool operator==(const ReverseIterator& other) const
            {
                return m_node == other.m_node;
            }

            inline bool operator!=(const ReverseIterator& other) const
            {
                return m_node != other.m_node;
            }

            inline ReverseIterator& operator++()
            {
                m_node = (m_node == nullptr) ? nullptr : m_node->gtPrev;
                return *this;
            }
        };

        Range();

        GenTree* Begin() const;
        GenTree* End() const;
        GenTree* EndExclusive() const;

        Iterator begin() const;
        Iterator end() const;

        ReverseIterator rbegin() const;
        ReverseIterator rend() const;

        bool IsValid() const;
        bool IsEmpty() const;
        bool IsSubRange() const;

        GenTree* FirstNonPhiNode() const;
        GenTree* FirstNonPhiOrCatchArgNode() const;

        void InsertBefore(GenTree* node, GenTree* insertionPoint);
        void InsertAfter(GenTree* node, GenTree* insertionPoint);

        void InsertBefore(const Range& range, GenTree* insertionPoint);
        void InsertAfter(const Range& range, GenTree* insertionPoint);

        void InsertAtBeginning(GenTree* node);
        void InsertAtEnd(GenTree* node);

        void InsertAtBeginning(const Range& range);
        void InsertAtEnd(const Range& range);

        void Remove(GenTree* node);
        void Remove(const Range& range);

        bool TryGetUse(GenTree* node, Use* use);

        Range GetTreeRange(GenTree* root, bool* isClosed) const;
        Range GetTreeRange(GenTree* root, bool* isClosed, unsigned* sideEffects) const;
        Range GetRangeOfOperandTrees(GenTree* root, bool* isClosed, unsigned* sideEffects) const;

#ifdef DEBUG
        bool ContainsNode(GenTree* node) const;
        bool CheckLIR(Compiler* compiler) const;
#endif
    };

public:
    static Range EmptyRange();
    static Range AsRange(GenTree* firstNode, GenTree* lastNode);
    static Range SeqTree(Compiler* compiler, GenTree* tree);

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
