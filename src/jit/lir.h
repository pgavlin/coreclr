// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#ifndef _LIR_H_
#define _LIR_H_

class Compiler;
struct GenTree;
struct BasicBlock;

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

            IsUnusedValue = 0x02, // Set on a node if it produces a value that is not
                                  // subsequently used. Should never be set on nodes
                                  // that return `false` for `GenTree::IsValue`. Note
                                  // that this bit should not be assumed to be valid
                                  // at all points during compilation: it is currently
                                  // only computed during target-dependent lowering.
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

    class ReadOnlyRange
    {
        friend class LIR;
        friend class Range;
        friend struct BasicBlock;

    private:
        GenTree* m_firstNode;
        GenTree* m_lastNode;

        ReadOnlyRange(GenTree* firstNode, GenTree* lastNode);

        ReadOnlyRange(const ReadOnlyRange& other) = delete;
        ReadOnlyRange& operator=(const ReadOnlyRange& other) = delete;

    public:
        class Iterator
        {
            friend class ReadOnlyRange;

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
            friend class ReadOnlyRange;

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
 
        ReadOnlyRange();
        ReadOnlyRange(ReadOnlyRange&& other);

        GenTree* FirstNode() const;
        GenTree* LastNode() const;

        bool IsEmpty() const;

        Iterator begin() const;
        Iterator end() const;

        ReverseIterator rbegin() const;
        ReverseIterator rend() const;

#ifdef DEBUG
        bool Contains(GenTree* node) const;
#endif
    };

    //------------------------------------------------------------------------
    // LIR::Range: Represents a contiguous range of LIR nodes. Provides a
    //             variety of utilites that modify the LIR contained in the
    //             range.
    //
    class Range : public ReadOnlyRange
    {
        friend class LIR;
        friend struct BasicBlock;

    private:
        Range(GenTree* firstNode, GenTree* lastNode);

        Range(const Range& other) = delete;
        Range& operator=(const Range& other) = delete;

        ReadOnlyRange GetMarkedRange(unsigned markCount, GenTree* start, bool* isClosed, unsigned* sideEffects) const;

    public:
        Range();
        Range(Range&& other);

        GenTree* FirstNonPhiNode() const;
        GenTree* FirstNonPhiOrCatchArgNode() const;

        ReadOnlyRange PhiNodes() const;
        ReadOnlyRange NonPhiNodes() const;

        void InsertBefore(GenTree* node, GenTree* insertionPoint);
        void InsertAfter(GenTree* node, GenTree* insertionPoint);

        void InsertBefore(Range&& range, GenTree* insertionPoint);
        void InsertAfter(Range&& range, GenTree* insertionPoint);

        void InsertAtBeginning(GenTree* node);
        void InsertAtEnd(GenTree* node);

        void InsertAtBeginning(Range&& range);
        void InsertAtEnd(Range&& range);

        void Remove(GenTree* node);
        Range Remove(GenTree* firstNode, GenTree* lastNode);
        Range Remove(ReadOnlyRange&& range);

        bool TryGetUse(GenTree* node, Use* use);

        ReadOnlyRange GetTreeRange(GenTree* root, bool* isClosed) const;
        ReadOnlyRange GetTreeRange(GenTree* root, bool* isClosed, unsigned* sideEffects) const;
        ReadOnlyRange GetRangeOfOperandTrees(GenTree* root, bool* isClosed, unsigned* sideEffects) const;

#ifdef DEBUG
        bool CheckLIR(Compiler* compiler, bool checkUnusedValues = false) const;
#endif
    };

public:
    static Range& AsRange(BasicBlock* block);

    static Range EmptyRange();
    static Range SeqTree(Compiler* compiler, GenTree* tree);
    static void DecRefCnts(Compiler* compiler, BasicBlock* block, const ReadOnlyRange& range);
};

#endif // _LIR_H_
