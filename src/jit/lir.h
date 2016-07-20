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

    template<typename TContainer>
    static Range AsRange(TContainer& container)
    {
        return Range(container->FirstLIRNodeSlot(), container->LastLIRNodeSlot());
    }
};

#endif // _LIR_H_
