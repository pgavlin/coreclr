// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                           XX
XX                               DecomposeLongs                              XX
XX                                                                           XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
*/

#ifndef _DECOMPOSELONGS_H_
#define _DECOMPOSELONGS_H_

#include "compiler.h"

class DecomposeLongs
{
public:

    DecomposeLongs(Compiler* compiler)
        : m_compiler(compiler)
    {
    }

    void PrepareForDecomposition();
    void DecomposeBlock(BasicBlock* block);
    
private:

    // Driver functions
    static Compiler::fgWalkResult DecompNodeHelper(LIR::Use& use);
    void DecomposeNode(LIR::Use& use);

    // Per-node type decompose cases
    void DecomposeLclVar(LIR::Use& use);
    void DecomposeLclFld(LIR::Use& use);
    void DecomposeStoreLclVar(LIR::Use& use);
    void DecomposeCast(LIR::Use& use);
    void DecomposeCnsLng(LIR::Use& use);
    void DecomposeCall(LIR::Use& use);
    void DecomposeStoreInd(LIR::Use& use);
    void DecomposeNot(LIR::Use& use);
    void DecomposeNeg(LIR::Use& use);
    void DecomposeArith(LIR::Use& use);

    // Helper functions
    void FinalizeDecomposition(LIR::Use& use, GenTree* loResult, GenTree* hiResult);

    static genTreeOps GetHiOper(genTreeOps oper);
    static genTreeOps GetLoOper(genTreeOps oper);

    // Data
    Compiler* m_compiler;
    BasicBlock* m_block;
    LIR::Range m_range;
};

#endif // _DECOMPOSELONGS_H_
