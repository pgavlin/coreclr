// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//
//   This class is used to perform data flow optimizations.
//   An example usage would be:
//
//     DataFlow flow(m_pCompiler);
//     flow.ForwardAnalysis(callback);
//
//  The "callback" object needs to implement the necessary callback
//  functions that  the "flow" object will call as the data flow
//  analysis progresses.
//
#pragma once

#include "compiler.h"
#include "jitstd.h"

class DataFlow
{
private:
    DataFlow();

public:
    // The callback interface that needs to be implemented by anyone
    // needing updates by the dataflow object.
    class Callback
    {
    public:
        Callback(Compiler* pCompiler);

        bool StartMerge(BasicBlock* block);
        void Merge(BasicBlock* block, BasicBlock* pred, flowList* preds);
        bool EndMerge(BasicBlock* block);

    private:
        Compiler* m_pCompiler;
    };

    DataFlow(Compiler* pCompiler);

    template <typename TCallback>
    void ForwardAnalysis(TCallback& callback);

private:
    Compiler* m_pCompiler;
};

template <typename TCallback>
void DataFlow::ForwardAnalysis(TCallback& callback)
{
    class Worklist final
    {
        BasicBlock* m_head;
        BasicBlock* m_tail;

    public:
        Worklist()
            : m_head(nullptr), m_tail(nullptr)
        {
        }

        bool IsEmpty() const
        {
            return m_head == nullptr;
        }

        bool Contains(BasicBlock* block) const
        {
            return (block->bbFlags & BBF_ON_WORKLIST) != 0;
        }

        void PushBack(BasicBlock* block)
        {
            if (!Contains(block))
            {
                if (m_head == nullptr)
                {
                    block->bbWorklistPrev = block->bbWorklistNext = m_head = m_tail = block;
                }
                else
                {
                    block->bbWorklistPrev  = m_tail;
                    m_tail->bbWorklistNext = block;
                    block->bbWorklistNext  = m_head;
                    m_head->bbWorklistPrev = block;
                    m_tail = block;
                }

                block->bbFlags |= BBF_ON_WORKLIST;
            }
        }

        BasicBlock* PopFront()
        {
            assert(!IsEmpty());

            BasicBlock* block = m_head;
            if (block == m_tail)
            {
                m_head = m_tail = nullptr;
            }
            else
            {
                m_head = block->bbWorklistNext;

                m_head->bbWorklistPrev = m_tail;
                m_tail->bbWorklistNext = m_head;
            }

            block->bbWorklistPrev = block->bbWorklistNext = nullptr;
            block->bbFlags &= ~BBF_ON_WORKLIST;
            return block;
        }
    };

    Worklist worklist;
    worklist.PushBack(m_pCompiler->fgFirstBB);
    while (!worklist.IsEmpty())
    {
        BasicBlock* block = worklist.PopFront();

        if (callback.StartMerge(block))
        {
            flowList* preds = m_pCompiler->BlockPredsWithEH(block);
            for (flowList* pred = preds; pred; pred = pred->flNext)
            {
                callback.Merge(block, pred->flBlock, preds);
            }
        }

        if (callback.EndMerge(block))
        {
            for (BasicBlock* block : block->GetAllSuccs(m_pCompiler))
            {
                worklist.PushBack(block);
            }
        }
    }
}
