// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                           XX
XX                            ee_jit.cpp                                     XX
XX                                                                           XX
XX   The functionality needed for the JIT DLL. Includes the DLL entry point  XX
XX                                                                           XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
*/

#include "jitpch.h"
#ifdef _MSC_VER
#pragma hdrstop
#endif
#include "emit.h"
#include "corexcep.h"

#if !defined(PLATFORM_UNIX)
#include <io.h>    // For _dup, _setmode
#include <fcntl.h> // For _O_TEXT
#endif

/*****************************************************************************/

FILE* jitstdout = nullptr;

ICorJitHost* g_jitHost = nullptr;
static CILJit* ILJitter = 0;        // The one and only JITTER I return
bool g_jitInitialized = false;
#ifndef FEATURE_MERGE_JIT_AND_ENGINE
HINSTANCE g_hInst = NULL;
#endif // FEATURE_MERGE_JIT_AND_ENGINE

/*****************************************************************************/

#ifdef  DEBUG

JitOptions jitOpts =
{
    NULL,   // methodName
    NULL,   // className
    0.1,    // CGknob
    0,      // testMask

    (JitOptions *)NULL // lastDummyField.
};

#endif // DEBUG

/*****************************************************************************/

extern "C"
void __stdcall jitStartup(ICorJitHost* jitHost)
{
    if (g_jitInitialized)
    {
        return;
    }

    g_jitHost = jitHost;

    assert(!JitConfig.isInitialized());
    JitConfig.initialize(jitHost);

#if defined(PLATFORM_UNIX)
    jitstdout = procstdout();
#else
    if (jitstdout == nullptr)
    {
        int stdoutFd = _fileno(procstdout());
        // Check fileno error output(s) -1 may overlap with errno result
        // but is included for completness.
        // We want to detect the case where the initial handle is null
        // or bogus and avoid making further calls.
        if ((stdoutFd != -1) && (stdoutFd != -2) && (errno != EINVAL))
        {
            int jitstdoutFd = _dup(_fileno(procstdout()));
            // Check the error status returned by dup.
            if (jitstdoutFd != -1)
            {
                _setmode(jitstdoutFd, _O_TEXT);
                jitstdout = _fdopen(jitstdoutFd, "w");
                assert(jitstdout != nullptr);

                // Prevent the FILE* from buffering its output in order to avoid calls to
                // `fflush()` throughout the code.
                setvbuf(jitstdout, nullptr, _IONBF, 0);
            }
        }
    }

    // If jitstdout is still null, fallback to whatever procstdout() was
    // initially set to.
    if (jitstdout == nullptr)
    {
        jitstdout = procstdout();
    }
#endif // PLATFORM_UNIX

#ifdef FEATURE_TRACELOGGING
    JitTelemetry::NotifyDllProcessAttach();
#endif
    Compiler::compStartup();

    g_jitInitialized = true;
}

void jitShutdown()
{
    if (!g_jitInitialized)
    {
        return;
    }

    Compiler::compShutdown();

    if (jitstdout != procstdout())
    {
        fclose(jitstdout);
    }

#ifdef FEATURE_TRACELOGGING
    JitTelemetry::NotifyDllProcessDetach();
#endif
}

#ifndef FEATURE_MERGE_JIT_AND_ENGINE

extern "C"
BOOL WINAPI     DllMain(HANDLE hInstance, DWORD dwReason, LPVOID pvReserved)
{
    if (dwReason == DLL_PROCESS_ATTACH)
    {
        g_hInst = (HINSTANCE)hInstance;
        DisableThreadLibraryCalls((HINSTANCE)hInstance);
#if defined(SELF_NO_HOST) && COR_JIT_EE_VERSION <= 460
        jitStartup(JitHost::getJitHost());
#endif
    }
    else if (dwReason == DLL_PROCESS_DETACH)
    {
        jitShutdown();
    }

    return TRUE;
}

HINSTANCE GetModuleInst()
{
    return (g_hInst);
}

extern "C"
void __stdcall sxsJitStartup(CoreClrCallbacks const & cccallbacks)
{
#ifndef SELF_NO_HOST
    InitUtilcode(cccallbacks);
#endif

#if COR_JIT_EE_VERSION <= 460
    jitStartup(JitHost::getJitHost());
#endif
}

#endif // !FEATURE_MERGE_JIT_AND_ENGINE

/*****************************************************************************/

struct CILJitSingletonAllocator { int x; };
const CILJitSingletonAllocator CILJitSingleton = { 0 };

void *__cdecl operator new(size_t, const CILJitSingletonAllocator&)
{
    static char CILJitBuff[sizeof(CILJit)];
    return CILJitBuff;
}

ICorJitCompiler* g_realJitCompiler = nullptr;

ICorJitCompiler* __stdcall getJit()
{
    if (ILJitter == 0)
    {
        ILJitter = new (CILJitSingleton) CILJit();
    }
    return(ILJitter);
}

/*****************************************************************************/

// Information kept in thread-local storage. This is used in the noway_assert exceptional path.
// If you are using it more broadly in retail code, you would need to understand the
// performance implications of accessing TLS.
//
// If the JIT is being statically linked, these methods must be implemented by the consumer.
#if !defined(FEATURE_MERGE_JIT_AND_ENGINE) || !defined(FEATURE_IMPLICIT_TLS)

__declspec(thread) void* gJitTls = nullptr;

static void* GetJitTls()
{
    return gJitTls;
}

void SetJitTls(void* value)
{
    gJitTls = value;
}

#else // !defined(FEATURE_MERGE_JIT_AND_ENGINE) || !defined(FEATURE_IMPLICIT_TLS)

extern "C"
{
void* GetJitTls();
void SetJitTls(void* value);
}

#endif // // defined(FEATURE_MERGE_JIT_AND_ENGINE) && defined(FEATURE_IMPLICIT_TLS)

#if defined(DEBUG)

JitTls::JitTls(ICorJitInfo* jitInfo)
    : m_compiler(nullptr)
    , m_logEnv(jitInfo)
{
    m_next = reinterpret_cast<JitTls*>(GetJitTls());
    SetJitTls(this);
}

JitTls::~JitTls()
{
    SetJitTls(m_next);
}

LogEnv* JitTls::GetLogEnv()
{
    return &reinterpret_cast<JitTls*>(GetJitTls())->m_logEnv;
}

Compiler* JitTls::GetCompiler()
{
    return reinterpret_cast<JitTls*>(GetJitTls())->m_compiler;
}

void JitTls::SetCompiler(Compiler* compiler)
{
    reinterpret_cast<JitTls*>(GetJitTls())->m_compiler = compiler;
}

#else // defined(DEBUG)

JitTls::JitTls(ICorJitInfo* jitInfo)
{
}

JitTls::~JitTls()
{
}

Compiler* JitTls::GetCompiler()
{
    return reinterpret_cast<Compiler*>(GetJitTls());
}

void JitTls::SetCompiler(Compiler* compiler)
{
    SetJitTls(compiler);
}

#endif // !defined(DEBUG)

//****************************************************************************
// The main JIT function for the 32 bit JIT.  See code:ICorJitCompiler#EEToJitInterface for more on the EE-JIT
// interface. Things really don't get going inside the JIT until the code:Compiler::compCompile#Phases
// method.  Usually that is where you want to go. 

CorJitResult CILJit::compileMethod (
            ICorJitInfo*       compHnd,
            CORINFO_METHOD_INFO* methodInfo,
            unsigned        flags,
            BYTE **         entryAddress,
            ULONG  *        nativeSizeOfCode)
{
    if (g_realJitCompiler != nullptr)
    {
        return g_realJitCompiler->compileMethod(compHnd, methodInfo, flags, entryAddress, nativeSizeOfCode);
    }

    CORJIT_FLAGS jitFlags = { 0 };

    DWORD jitFlagsSize = 0;
#if COR_JIT_EE_VERSION > 460
    if (flags == CORJIT_FLG_CALL_GETJITFLAGS)
    {
        jitFlagsSize = compHnd->getJitFlags(&jitFlags, sizeof(jitFlags));
    }
#endif

    assert(jitFlagsSize <= sizeof(jitFlags));
    if (jitFlagsSize == 0)
    {
        jitFlags.corJitFlags = flags;
    }

    int                     result;
    void *                  methodCodePtr = NULL;
    CORINFO_METHOD_HANDLE   methodHandle  = methodInfo->ftn;

    JitTls jitTls(compHnd); // Initialize any necessary thread-local state

    assert(methodInfo->ILCode);

    result = jitNativeCode(methodHandle,
                           methodInfo->scope,
                           compHnd,
                           methodInfo,
                           &methodCodePtr,
                           nativeSizeOfCode,
                           &jitFlags,
                           NULL);

    if (result == CORJIT_OK)
        *entryAddress = (BYTE*)methodCodePtr;

    return CorJitResult(result);
}

/*****************************************************************************
 * Notification from VM to clear any caches
 */
void CILJit::clearCache ( void )
{
    if (g_realJitCompiler != nullptr)
    {
        g_realJitCompiler->clearCache();
        // Continue...
    }

    return;
}

/*****************************************************************************
 * Notify vm that we have something to clean up
 */
BOOL CILJit::isCacheCleanupRequired ( void )
{
    BOOL doCleanup;

    if (g_realJitCompiler != nullptr)
    {
        if (g_realJitCompiler->isCacheCleanupRequired())
            return TRUE;
        // Continue...
    }

    return FALSE;
}

void CILJit::ProcessShutdownWork(ICorStaticInfo* statInfo)
{
    if (g_realJitCompiler != nullptr)
    {
        g_realJitCompiler->ProcessShutdownWork(statInfo);
        // Continue, by shutting down this JIT as well.
    }

#ifdef FEATURE_MERGE_JIT_AND_ENGINE
    jitShutdown();
#endif

    Compiler::ProcessShutdownWork(statInfo);
}

/*****************************************************************************
 * Verify the JIT/EE interface identifier.
 */
void CILJit::getVersionIdentifier(GUID* versionIdentifier)
{
    if (g_realJitCompiler != nullptr)
    {
        g_realJitCompiler->getVersionIdentifier(versionIdentifier);
        return;
    }

    assert(versionIdentifier != nullptr);
    memcpy(versionIdentifier, &JITEEVersionIdentifier, sizeof(GUID));
}

/*****************************************************************************
 * Determine the maximum length of SIMD vector supported by this JIT.
 */
unsigned CILJit::getMaxIntrinsicSIMDVectorLength(DWORD cpuCompileFlags)
{
    if (g_realJitCompiler != nullptr)
    {
        return g_realJitCompiler->getMaxIntrinsicSIMDVectorLength(cpuCompileFlags);
    }

#ifdef _TARGET_AMD64_
#ifdef FEATURE_AVX_SUPPORT
    if (((cpuCompileFlags & CORJIT_FLG_PREJIT) == 0) &&
        ((cpuCompileFlags & CORJIT_FLG_FEATURE_SIMD) != 0) &&
        ((cpuCompileFlags & CORJIT_FLG_USE_AVX2) != 0))
    {
        if (JitConfig.EnableAVX() != 0)
        {
            return 32;
        }
    }
#endif // FEATURE_AVX_SUPPORT
    return 16;
#else // !_TARGET_AMD64_
    return 0;
#endif // !_TARGET_AMD64_
}

void CILJit::setRealJit(ICorJitCompiler* realJitCompiler)
{
    g_realJitCompiler = realJitCompiler;
}


/*****************************************************************************
 * Returns the number of bytes required for the given type argument
 */

unsigned           Compiler::eeGetArgSize(CORINFO_ARG_LIST_HANDLE list, CORINFO_SIG_INFO* sig)
{
#if defined(_TARGET_AMD64_) 

    // Everything fits into a single 'slot' size
    // to accommodate irregular sized structs, they are passed byref

#ifdef FEATURE_UNIX_AMD64_STRUCT_PASSING
    CORINFO_CLASS_HANDLE        argClass;
    CorInfoType argTypeJit = strip(info.compCompHnd->getArgType(sig, list, &argClass));
    var_types argType = JITtype2varType(argTypeJit);
    if (varTypeIsStruct(argType))
    {
        unsigned structSize = info.compCompHnd->getClassSize(argClass);
        return structSize;  // TODO: roundUp() needed here?
    }
#endif // FEATURE_UNIX_AMD64_STRUCT_PASSING
    return sizeof(size_t);

#else // !_TARGET_AMD64_ 

    CORINFO_CLASS_HANDLE        argClass;
    CorInfoType argTypeJit = strip(info.compCompHnd->getArgType(sig, list, &argClass));
    var_types argType = JITtype2varType(argTypeJit);

    if (varTypeIsStruct(argType))
    {
        unsigned structSize = info.compCompHnd->getClassSize(argClass);

        // make certain the EE passes us back the right thing for refanys
        assert(argTypeJit != CORINFO_TYPE_REFANY || structSize == 2*sizeof(void*));

#if FEATURE_MULTIREG_ARGS
        // For each target that supports passing struct args in multiple registers 
        // apply the target specific rules for them here:
#if defined(_TARGET_ARM64_)
        // Any structs that are larger than MAX_PASS_MULTIREG_BYTES are always passed by reference
        if (structSize > MAX_PASS_MULTIREG_BYTES)
        {
            // This struct is passed by reference using a single 'slot'
            return TARGET_POINTER_SIZE;
        }
        else
        {
            // Is the struct larger than 16 bytes
            if (structSize > (2 * TARGET_POINTER_SIZE))
            {
                var_types hfaType = GetHfaType(argClass);   // set to float or double if it is an HFA, otherwise TYP_UNDEF
                bool      isHfa = (hfaType != TYP_UNDEF);
                if (!isHfa)
                {
                    // This struct is passed by reference using a single 'slot'
                    return TARGET_POINTER_SIZE;
                }
            }
        }
        // otherwise will we pass this struct by value in multiple registers
        //
#elif defined(_TARGET_ARM_)
        //  otherwise will we pass this struct by value in multiple registers
#else // 
        NYI("unknown target");
#endif // defined(_TARGET_XXX_)
#endif // FEATURE_MULTIREG_ARGS

        // we pass this struct by value in multiple registers
        return (unsigned)roundUp(structSize, TARGET_POINTER_SIZE);
    }
    else
    {
        unsigned  argSize = sizeof(int) * genTypeStSz(argType);
        assert(0 < argSize && argSize <= sizeof(__int64));
        return (unsigned)roundUp(argSize, TARGET_POINTER_SIZE);
    }
#endif
}

/*****************************************************************************/

GenTreePtr          Compiler::eeGetPInvokeCookie(CORINFO_SIG_INFO *szMetaSig)
{
    void * cookie, * pCookie;
    cookie = info.compCompHnd->GetCookieForPInvokeCalliSig(szMetaSig, &pCookie);
    assert((cookie == NULL) != (pCookie == NULL));

    return gtNewIconEmbHndNode(cookie, pCookie, GTF_ICON_PINVKI_HDL);
}

//------------------------------------------------------------------------
// eeGetArrayDataOffset: Gets the offset of a SDArray's first element
//
// Arguments:
//    type - The array element type
//
// Return Value:
//    The offset to the first array element. 

unsigned           Compiler::eeGetArrayDataOffset(var_types type)
{
    return varTypeIsGC(type) ? eeGetEEInfo()->offsetOfObjArrayData 
                                                 : offsetof(CORINFO_Array, u1Elems);
}

//------------------------------------------------------------------------
// eeGetMDArrayDataOffset: Gets the offset of a MDArray's first element
//
// Arguments:
//    type - The array element type
//    rank - The array rank
//
// Return Value:
//    The offset to the first array element.
//
// Assumptions:
//    The rank should be greater than 0.

unsigned           Compiler::eeGetMDArrayDataOffset(var_types type, unsigned rank)
{
    assert(rank > 0);
    // Note that below we're specifically using genTypeSize(TYP_INT) because array 
    // indices are not native int.
    return eeGetArrayDataOffset(type) + 2 * genTypeSize(TYP_INT) * rank;
}

/*****************************************************************************/

void                Compiler::eeGetStmtOffsets()
{
    ULONG32                      offsetsCount;
    DWORD                   *    offsets;
    ICorDebugInfo::BoundaryTypes offsetsImplicit;

    info.compCompHnd->getBoundaries(info.compMethodHnd,
                                    &offsetsCount,
                                    &offsets,
                                    &offsetsImplicit);

    /* Set the implicit boundaries */

    info.compStmtOffsetsImplicit = (ICorDebugInfo::BoundaryTypes)offsetsImplicit;

    /* Process the explicit boundaries */

    info.compStmtOffsetsCount = 0;

    if (offsetsCount == 0)
        return;

    info.compStmtOffsets = new (this, CMK_DebugInfo) IL_OFFSET[offsetsCount];

    for (unsigned i = 0; i < offsetsCount; i++)
    {
        if (offsets[i] > info.compILCodeSize)
            continue;

        info.compStmtOffsets[info.compStmtOffsetsCount] = offsets[i];
        info.compStmtOffsetsCount++;
    }

    info.compCompHnd->freeArray(offsets);
}

/*****************************************************************************
 *
 *                  Debugging support - Local var info
 */

void                Compiler::eeSetLVcount  (unsigned      count)
{
    assert(opts.compScopeInfo);
    
    JITDUMP("VarLocInfo count is %d\n", count);

    eeVarsCount = count;
    if (eeVarsCount)
        eeVars = (VarResultInfo *)info.compCompHnd->allocateArray(eeVarsCount * sizeof(eeVars[0]));
    else
        eeVars = NULL;
}

void                Compiler::eeSetLVinfo
                                (unsigned                   which,
                                 UNATIVE_OFFSET             startOffs,
                                 UNATIVE_OFFSET             length,
                                 unsigned                   varNum,
                                 unsigned                   LVnum,
                                 VarName                    name,
                                 bool                       avail,
                                 const Compiler::siVarLoc & varLoc)
{
    // ICorDebugInfo::VarLoc and Compiler::siVarLoc have to overlap
    // This is checked in siInit()

    assert(opts.compScopeInfo);
    assert(eeVarsCount > 0);
    assert(which < eeVarsCount);

    if (eeVars != NULL)
    {
        eeVars[which].startOffset   = startOffs;
        eeVars[which].endOffset     = startOffs + length;
        eeVars[which].varNumber     = varNum;
        eeVars[which].loc           = varLoc;
    }
}

void                Compiler::eeSetLVdone()
{
    // necessary but not sufficient condition that the 2 struct definitions overlap
    assert(sizeof(eeVars[0]) == sizeof(ICorDebugInfo::NativeVarInfo));
    assert(opts.compScopeInfo);

#ifdef DEBUG
    if (verbose)
    {
        eeDispVars(info.compMethodHnd,
                   eeVarsCount,
                   (ICorDebugInfo::NativeVarInfo *) eeVars);
    }
#endif // DEBUG

    info.compCompHnd->setVars(info.compMethodHnd,
                              eeVarsCount,
                              (ICorDebugInfo::NativeVarInfo *) eeVars);

    eeVars = NULL; // We give up ownership after setVars()
}

void            Compiler::eeGetVars()
{
    ICorDebugInfo::ILVarInfo *  varInfoTable;
    ULONG32                     varInfoCount;
    bool                        extendOthers;

    info.compCompHnd->getVars(info.compMethodHnd,
                              &varInfoCount, &varInfoTable, &extendOthers);

#ifdef DEBUG
    if (verbose)
        printf("getVars() returned cVars = %d, extendOthers = %s\n", varInfoCount, extendOthers ? "true" : "false");
#endif

    // Over allocate in case extendOthers is set.

    SIZE_T  varInfoCountExtra = varInfoCount;
    if (extendOthers)
        varInfoCountExtra += info.compLocalsCount;

    if (varInfoCountExtra == 0)
        return;

    info.compVarScopes = new (this, CMK_DebugInfo) VarScopeDsc[varInfoCountExtra];

    VarScopeDsc* localVarPtr = info.compVarScopes;
    ICorDebugInfo::ILVarInfo *v = varInfoTable;

    for (unsigned i = 0; i < varInfoCount; i++, v++)
    {
#ifdef DEBUG
        if (verbose)
            printf("var:%d start:%d end:%d\n",
                   v->varNumber,
                   v->startOffset,
                   v->endOffset);
#endif

        if (v->startOffset >= v->endOffset)
            continue;

        assert(v->startOffset <= info.compILCodeSize);
        assert(v->endOffset   <= info.compILCodeSize);

        localVarPtr->vsdLifeBeg = v->startOffset;
        localVarPtr->vsdLifeEnd = v->endOffset;
        localVarPtr->vsdLVnum   = i;
        localVarPtr->vsdVarNum  = compMapILvarNum(v->varNumber);

#ifdef DEBUG
        localVarPtr->vsdName    = gtGetLclVarName(localVarPtr->vsdVarNum);
#endif

        localVarPtr++;
        info.compVarScopesCount++;
    }

    /* If extendOthers is set, then assume the scope of unreported vars
       is the entire method. Note that this will cause fgExtendDbgLifetimes()
       to zero-initalize all of them. This will be expensive if it's used
       for too many variables.
     */
    if  (extendOthers)
    {
        // Allocate a bit-array for all the variables and initialize to false

        bool * varInfoProvided = (bool *)compGetMemA(info.compLocalsCount *
                                                sizeof(varInfoProvided[0]));
        unsigned i;
        for (i = 0; i < info.compLocalsCount; i++)
            varInfoProvided[i] = false;

        // Find which vars have absolutely no varInfo provided

        for (i = 0; i < info.compVarScopesCount; i++)
            varInfoProvided[info.compVarScopes[i].vsdVarNum] = true;

        // Create entries for the variables with no varInfo

        for (unsigned varNum = 0; varNum < info.compLocalsCount; varNum++)
        {
            if (varInfoProvided[varNum])
                continue;

            // Create a varInfo with scope over the entire method

            localVarPtr->vsdLifeBeg = 0;
            localVarPtr->vsdLifeEnd = info.compILCodeSize;
            localVarPtr->vsdVarNum  = varNum;
            localVarPtr->vsdLVnum   = info.compVarScopesCount;

#ifdef DEBUG
            localVarPtr->vsdName    = gtGetLclVarName(localVarPtr->vsdVarNum);
#endif

            localVarPtr++;
            info.compVarScopesCount++;
        }
    }

    assert(localVarPtr <= info.compVarScopes + varInfoCountExtra);

    if (varInfoCount != 0)
        info.compCompHnd->freeArray(varInfoTable);

#ifdef DEBUG
    if (verbose)
        compDispLocalVars();
#endif // DEBUG
}

#ifdef DEBUG
void                Compiler::eeDispVar(ICorDebugInfo::NativeVarInfo* var)
{
    const char* name = NULL;

    if (var->varNumber == (DWORD)ICorDebugInfo::VARARGS_HND_ILNUM)
        name = "varargsHandle";
    else if (var->varNumber == (DWORD)ICorDebugInfo::RETBUF_ILNUM)
        name = "retBuff";
    else if (var->varNumber == (DWORD)ICorDebugInfo::TYPECTXT_ILNUM)
        name = "typeCtx";

    printf("%3d(%10s) : From %08Xh to %08Xh, in ",
        var->varNumber,
        (VarNameToStr(name) == NULL) ? "UNKNOWN" : VarNameToStr(name),
        var->startOffset,
        var->endOffset);

    switch (var->loc.vlType)
    {
    case VLT_REG:
    case VLT_REG_BYREF:
    case VLT_REG_FP:
        printf("%s", getRegName(var->loc.vlReg.vlrReg));
        if (var->loc.vlType == (ICorDebugInfo::VarLocType)VLT_REG_BYREF)
        {
            printf(" byref");
        }
        break;

    case VLT_STK:
    case VLT_STK_BYREF:
        if ((int) var->loc.vlStk.vlsBaseReg != (int) ICorDebugInfo::REGNUM_AMBIENT_SP)
        {
            printf("%s[%d] (1 slot)",    getRegName(var->loc.vlStk.vlsBaseReg),
                                          var->loc.vlStk.vlsOffset);
        }
        else
        {
            printf(STR_SPBASE "'[%d] (1 slot)",  var->loc.vlStk.vlsOffset);
        }
        if (var->loc.vlType == (ICorDebugInfo::VarLocType)VLT_REG_BYREF)
        {
            printf(" byref");
        }
        break;

#ifndef _TARGET_AMD64_
    case VLT_REG_REG:
        printf("%s-%s",     getRegName(var->loc.vlRegReg.vlrrReg1),
                            getRegName(var->loc.vlRegReg.vlrrReg2));
        break;

    case VLT_REG_STK:
        if ((int) var->loc.vlRegStk.vlrsStk.vlrssBaseReg != (int) ICorDebugInfo::REGNUM_AMBIENT_SP)
        {
            printf("%s-%s[%d]", getRegName(var->loc.vlRegStk.vlrsReg),
                                getRegName(var->loc.vlRegStk.vlrsStk.vlrssBaseReg),
                                var->loc.vlRegStk.vlrsStk.vlrssOffset);
        }
        else
        {
            printf("%s-" STR_SPBASE "'[%d]", getRegName(var->loc.vlRegStk.vlrsReg),
                                             var->loc.vlRegStk.vlrsStk.vlrssOffset);
        }
        break;

    case VLT_STK_REG:
        unreached(); // unexpected

    case VLT_STK2:
        if ((int) var->loc.vlStk2.vls2BaseReg != (int) ICorDebugInfo::REGNUM_AMBIENT_SP)
        {
            printf("%s[%d] (2 slots)", getRegName(var->loc.vlStk2.vls2BaseReg),
                                      var->loc.vlStk2.vls2Offset);
        }
        else
        {
            printf(STR_SPBASE "'[%d] (2 slots)", var->loc.vlStk2.vls2Offset);
        }
        break;

    case VLT_FPSTK:
        printf("ST(L-%d)",  var->loc.vlFPstk.vlfReg);
        break;

    case VLT_FIXED_VA:
        printf("fxd_va[%d]", var->loc.vlFixedVarArg.vlfvOffset);
        break;
#endif // !_TARGET_AMD64_

    default:
        unreached(); // unexpected
    }

    printf("\n");
}

// Same parameters as ICorStaticInfo::setVars().
void                Compiler::eeDispVars(CORINFO_METHOD_HANDLE           ftn,
                                         ULONG32                         cVars,
                                         ICorDebugInfo::NativeVarInfo*   vars)
{
    printf("*************** Variable debug info\n");
    printf("%d vars\n", cVars);
    for (unsigned i = 0; i < cVars; i++)
    {
        eeDispVar(&vars[i]);
    }
}
#endif // DEBUG

/*****************************************************************************
 *
 *                  Debugging support - Line number info
 */

void                Compiler::eeSetLIcount   (unsigned       count)
{
    assert(opts.compDbgInfo);
    
    eeBoundariesCount = count;
    if (eeBoundariesCount)
        eeBoundaries = (boundariesDsc *) info.compCompHnd->allocateArray(eeBoundariesCount * sizeof(eeBoundaries[0]));
    else
        eeBoundaries = NULL;
}

void                Compiler::eeSetLIinfo  (unsigned       which,
                                            UNATIVE_OFFSET nativeOffset,
                                            IL_OFFSET      ilOffset,
                                            bool           stkEmpty,
                                            bool           callInstruction)
{
    assert(opts.compDbgInfo);
    assert(eeBoundariesCount > 0);
    assert(which < eeBoundariesCount);

    if (eeBoundaries != NULL)
    {
        eeBoundaries[which].nativeIP = nativeOffset;
        eeBoundaries[which].ilOffset = ilOffset;
        eeBoundaries[which].sourceReason = stkEmpty ? ICorDebugInfo::STACK_EMPTY : 0;
        eeBoundaries[which].sourceReason |= callInstruction ? ICorDebugInfo::CALL_INSTRUCTION : 0;
    }
}

void                Compiler::eeSetLIdone()
{
    assert(opts.compDbgInfo);

#if defined(DEBUG)
    if (verbose)
    {
        eeDispLineInfos();
    }
#endif // DEBUG

    // necessary but not sufficient condition that the 2 struct definitions overlap
    assert(sizeof(eeBoundaries[0]) == sizeof(ICorDebugInfo::OffsetMapping));

    info.compCompHnd->setBoundaries(info.compMethodHnd,
                                    eeBoundariesCount,
                                    (ICorDebugInfo::OffsetMapping *) eeBoundaries);

    eeBoundaries = NULL; // we give up ownership after setBoundaries();
}

#if defined(DEBUG)

/* static */
void                Compiler::eeDispILOffs(IL_OFFSET offs)
{
    const char * specialOffs[] = { "EPILOG", "PROLOG", "NO_MAP" };

    switch ((int)offs) // Need the cast since offs is unsigned and the case statements are comparing to signed.
    {
    case ICorDebugInfo::EPILOG:
    case ICorDebugInfo::PROLOG:
    case ICorDebugInfo::NO_MAPPING:
        assert(DWORD(ICorDebugInfo::EPILOG) + 1 == (unsigned)ICorDebugInfo::PROLOG);
        assert(DWORD(ICorDebugInfo::EPILOG) + 2 == (unsigned)ICorDebugInfo::NO_MAPPING);
        int specialOffsNum;
        specialOffsNum = offs - DWORD(ICorDebugInfo::EPILOG);
        printf("%s", specialOffs[specialOffsNum]);
        break;
    default:
        printf("0x%04X", offs);
    }
}

/* static */
void                Compiler::eeDispLineInfo(const boundariesDsc* line)
{
    printf("IL offs ");

    eeDispILOffs(line->ilOffset);

    printf(" : 0x%08X", line->nativeIP);
    if (line->sourceReason != 0)
    {
        // It seems like it should probably never be zero since ICorDebugInfo::SOURCE_TYPE_INVALID is zero.
        // However, the JIT has always generated this and printed "stack non-empty".

        printf(" ( ");
        if ((line->sourceReason & ICorDebugInfo::STACK_EMPTY) != 0)
        {
            printf("STACK_EMPTY ");
        }
        if ((line->sourceReason & ICorDebugInfo::CALL_INSTRUCTION) != 0)
        {
            printf("CALL_INSTRUCTION ");
        }
        if ((line->sourceReason & ICorDebugInfo::CALL_SITE) != 0)
        {
            printf("CALL_SITE ");
        }
        printf(")");
    }
    printf("\n");

    // We don't expect to see any other bits.
    assert((line->sourceReason & ~(ICorDebugInfo::STACK_EMPTY | ICorDebugInfo::CALL_INSTRUCTION)) == 0);
}

void                Compiler::eeDispLineInfos()
{
    printf("IP mapping count : %d\n", eeBoundariesCount); // this might be zero
    for (unsigned i = 0; i < eeBoundariesCount; i++)
    {
        eeDispLineInfo(&eeBoundaries[i]);
    }
    printf("\n");
}
#endif // DEBUG

/*****************************************************************************
 *
 *                      ICorJitInfo wrapper functions
 *
 * In many cases here, we don't tell the VM about various unwind or EH information if
 * we're an altjit for an unexpected architecture. If it's not a same architecture JIT
 * (e.g., host AMD64, target ARM64), then VM will get confused anyway.
 */

void            Compiler::eeReserveUnwindInfo(BOOL isFunclet,
                                              BOOL isColdCode,
                                              ULONG unwindSize)
{
#ifdef DEBUG
    if (verbose)
    {
        printf("reserveUnwindInfo(isFunclet=%s, isColdCode=%s, unwindSize=0x%x)\n",
            isFunclet  ? "TRUE" : "FALSE",
            isColdCode ? "TRUE" : "FALSE",
            unwindSize);
    }
#endif // DEBUG

    if (info.compMatchedVM)
    {
        info.compCompHnd->reserveUnwindInfo(isFunclet, isColdCode, unwindSize);
    }
}

void            Compiler::eeAllocUnwindInfo(BYTE*  pHotCode,
                                            BYTE*  pColdCode,
                                            ULONG  startOffset,
                                            ULONG  endOffset,
                                            ULONG  unwindSize,
                                            BYTE*  pUnwindBlock,
                                            CorJitFuncKind funcKind)
{
#ifdef DEBUG
    if (verbose)
    {
        printf("allocUnwindInfo(pHotCode=0x%p, pColdCode=0x%p, startOffset=0x%x, endOffset=0x%x, unwindSize=0x%x, pUnwindBlock=0x%p, funKind=%d",
            dspPtr(pHotCode),
            dspPtr(pColdCode),
            startOffset,
            endOffset,
            unwindSize,
            dspPtr(pUnwindBlock),
            funcKind);
        switch (funcKind)
        {
        case CORJIT_FUNC_ROOT:    printf(" (main function)"); break;
        case CORJIT_FUNC_HANDLER: printf(" (handler)");       break;
        case CORJIT_FUNC_FILTER:  printf(" (filter)");        break;
        default:                  printf(" (ILLEGAL)");       break;
        }
        printf(")\n");
    }
#endif // DEBUG

    if (info.compMatchedVM)
    {
        info.compCompHnd->allocUnwindInfo(
            pHotCode,
            pColdCode,
            startOffset,
            endOffset,
            unwindSize,
            pUnwindBlock,
            funcKind);
    }
}

void                Compiler::eeSetEHcount(unsigned cEH)
{
#ifdef DEBUG
    if (verbose)
    {
        printf("setEHcount(cEH=%u)\n", cEH);
    }
#endif // DEBUG

    if (info.compMatchedVM)
    {
        info.compCompHnd->setEHcount(cEH);
    }
}

void                Compiler::eeSetEHinfo(unsigned                 EHnumber,
                                          const CORINFO_EH_CLAUSE *clause)
{
#ifdef DEBUG
    if (opts.dspEHTable)
    {
        dispOutgoingEHClause(EHnumber, *clause);
    }
#endif // DEBUG

    if (info.compMatchedVM)
    {
        info.compCompHnd->setEHinfo(EHnumber, clause);
    }
}

WORD                Compiler::eeGetRelocTypeHint(void * target)
{
    if (info.compMatchedVM)
    {
        return info.compCompHnd->getRelocTypeHint(target);
    }
    else
    {
        // No hints
        return (WORD)-1;
    }
}


CORINFO_FIELD_HANDLE Compiler::eeFindJitDataOffs(unsigned dataOffs)
{
    // Data offsets are marked by the fact that the low two bits are 0b01 0x1
    assert(dataOffs < 0x40000000);
    return (CORINFO_FIELD_HANDLE)(size_t)((dataOffs << iaut_SHIFT) | iaut_DATA_OFFSET);
}

bool Compiler::eeIsJitDataOffs(CORINFO_FIELD_HANDLE field)
{
    // if 'field' is a jit data offset it has to fit into a 32-bit unsigned int
    unsigned value = static_cast<unsigned>(reinterpret_cast<uintptr_t>(field));
    if (((CORINFO_FIELD_HANDLE)(size_t)value) != field)
    {
        return false;   // upper bits were set, not a jit data offset
    }

    // Data offsets are marked by the fact that the low two bits are 0b01 0x1
    return (value & iaut_MASK) == iaut_DATA_OFFSET;
}

int Compiler::eeGetJitDataOffs(CORINFO_FIELD_HANDLE  field)
{
    // Data offsets are marked by the fact that the low two bits are 0b01 0x1
    if (eeIsJitDataOffs(field))
    {
        unsigned dataOffs = static_cast<unsigned>(reinterpret_cast<uintptr_t>(field));
        assert(((CORINFO_FIELD_HANDLE)(size_t)dataOffs) == field);
        assert(dataOffs < 0x40000000);
        return (static_cast<int>(reinterpret_cast<intptr_t>(field))) >> iaut_SHIFT;
    }
    else
    {
        return -1;
    }
}


/*****************************************************************************
 *
 *                      ICorStaticInfo wrapper functions
 */

#if defined(FEATURE_UNIX_AMD64_STRUCT_PASSING)

#ifdef DEBUG
void Compiler::dumpSystemVClassificationType(SystemVClassificationType ct)
{
    switch (ct)
    {
    case SystemVClassificationTypeUnknown:              printf("UNKNOWN");              break;
    case SystemVClassificationTypeStruct:               printf("Struct");               break;
    case SystemVClassificationTypeNoClass:              printf("NoClass");              break;
    case SystemVClassificationTypeMemory:               printf("Memory");               break;
    case SystemVClassificationTypeInteger:              printf("Integer");              break;
    case SystemVClassificationTypeIntegerReference:     printf("IntegerReference");     break;
    case SystemVClassificationTypeIntegerByRef:         printf("IntegerByReference");   break;
    case SystemVClassificationTypeSSE:                  printf("SSE");                  break;
    default:                                            printf("ILLEGAL");              break;
    }
}
#endif // DEBUG

void Compiler::eeGetSystemVAmd64PassStructInRegisterDescriptor(/*IN*/  CORINFO_CLASS_HANDLE structHnd,
                                                               /*OUT*/ SYSTEMV_AMD64_CORINFO_STRUCT_REG_PASSING_DESCRIPTOR* structPassInRegDescPtr)
{
    bool ok = info.compCompHnd->getSystemVAmd64PassStructInRegisterDescriptor(structHnd, structPassInRegDescPtr);
    noway_assert(ok);

#ifdef DEBUG
    if (verbose)
    {
        printf("**** getSystemVAmd64PassStructInRegisterDescriptor(0x%x (%s), ...) =>\n", dspPtr(structHnd), eeGetClassName(structHnd));
        printf("        passedInRegisters = %s\n", dspBool(structPassInRegDescPtr->passedInRegisters));
        if (structPassInRegDescPtr->passedInRegisters)
        {
            printf("        eightByteCount   = %d\n", structPassInRegDescPtr->eightByteCount);
            for (unsigned int i = 0; i < structPassInRegDescPtr->eightByteCount; i++)
            {
                printf("        eightByte #%d -- classification: ", i);
                dumpSystemVClassificationType(structPassInRegDescPtr->eightByteClassifications[i]);
                printf(", byteSize: %d, byteOffset: %d\n",
                    structPassInRegDescPtr->eightByteSizes[i],
                    structPassInRegDescPtr->eightByteOffsets[i]);
            }
        }
    }
#endif // DEBUG
}

#endif // FEATURE_UNIX_AMD64_STRUCT_PASSING

#if COR_JIT_EE_VERSION <= 460

// Validate the token to determine whether to turn the bad image format exception into
// verification failure (for backward compatibility)
static bool isValidTokenForTryResolveToken(ICorJitInfo* corInfo, CORINFO_RESOLVED_TOKEN* resolvedToken)
{
    if (!corInfo->isValidToken(resolvedToken->tokenScope, resolvedToken->token))
        return false;

    CorInfoTokenKind tokenType = resolvedToken->tokenType;
    switch (TypeFromToken(resolvedToken->token))
    {
    case mdtModuleRef:
    case mdtTypeDef:
    case mdtTypeRef:
    case mdtTypeSpec:
        if ((tokenType & CORINFO_TOKENKIND_Class) == 0)
            return false;
        break;

    case mdtMethodDef:
    case mdtMethodSpec:
        if ((tokenType & CORINFO_TOKENKIND_Method) == 0)
            return false;
        break;

    case mdtFieldDef:
        if ((tokenType & CORINFO_TOKENKIND_Field) == 0)
            return false;
        break;

    case mdtMemberRef:
        if ((tokenType & (CORINFO_TOKENKIND_Method | CORINFO_TOKENKIND_Field)) == 0)
            return false;
        break;

    default:
        return false;
    }

    return true;
}

// This type encapsulates the information necessary for `TryResolveTokenFilter` and
// `eeTryResolveToken` below.
struct TryResolveTokenFilterParam
{
    ICorJitInfo* m_corInfo;
    CORINFO_RESOLVED_TOKEN* m_resolvedToken;
    EXCEPTION_POINTERS m_exceptionPointers;
    bool m_success;
};

LONG TryResolveTokenFilter(struct _EXCEPTION_POINTERS* exceptionPointers, void* theParam)
{
    assert(exceptionPointers->ExceptionRecord->ExceptionCode != SEH_VERIFICATION_EXCEPTION);

    // Backward compatibility: Convert bad image format exceptions thrown by the EE while resolving token to verification exceptions 
    // if we are verifying. Verification exceptions will cause the JIT of the basic block to fail, but the JITing of the whole method 
    // is still going to succeed. This is done for backward compatibility only. Ideally, we would always treat bad tokens in the IL 
    // stream as fatal errors.
    if (exceptionPointers->ExceptionRecord->ExceptionCode == EXCEPTION_COMPLUS)
    {
        auto* param = reinterpret_cast<TryResolveTokenFilterParam*>(theParam);
        if (!isValidTokenForTryResolveToken(param->m_corInfo, param->m_resolvedToken))
        {
            param->m_exceptionPointers = *exceptionPointers;
            return param->m_corInfo->FilterException(exceptionPointers);
        }
    }

    return EXCEPTION_CONTINUE_SEARCH;
}

bool Compiler::eeTryResolveToken(CORINFO_RESOLVED_TOKEN* resolvedToken)
{
    TryResolveTokenFilterParam param;
    param.m_corInfo = info.compCompHnd;
    param.m_resolvedToken = resolvedToken;
    param.m_success = true;

    PAL_TRY(TryResolveTokenFilterParam*, pParam, &param)
    {
        pParam->m_corInfo->resolveToken(pParam->m_resolvedToken);
    }
    PAL_EXCEPT_FILTER(TryResolveTokenFilter)
    {
        if (param.m_exceptionPointers.ExceptionRecord->ExceptionCode == EXCEPTION_COMPLUS)
        {
            param.m_corInfo->HandleException(&param.m_exceptionPointers);
        }

        param.m_success = false;
    }
    PAL_ENDTRY

    return param.m_success;
}

struct TrapParam
{
    ICorJitInfo* m_corInfo;
    EXCEPTION_POINTERS m_exceptionPointers;

    void (*m_function)(void*);
    void* m_param;
    bool m_success;
};

static LONG __EEFilter(PEXCEPTION_POINTERS exceptionPointers, void* param)
{
    auto* trapParam = reinterpret_cast<TrapParam*>(param);
    trapParam->m_exceptionPointers = *exceptionPointers;
    return trapParam->m_corInfo->FilterException(exceptionPointers);
}

bool Compiler::eeRunWithErrorTrapImp(void (*function)(void*), void* param)
{
    TrapParam trapParam;
    trapParam.m_corInfo = info.compCompHnd;
    trapParam.m_function = function;
    trapParam.m_param = param;
    trapParam.m_success = true;

    PAL_TRY(TrapParam*, __trapParam, &trapParam)
    {
        __trapParam->m_function(__trapParam->m_param);
    }
    PAL_EXCEPT_FILTER(__EEFilter)
    {
        trapParam.m_corInfo->HandleException(&trapParam.m_exceptionPointers);
        trapParam.m_success = false;
    }
    PAL_ENDTRY

    return trapParam.m_success;
}

#else // CORJIT_EE_VER <= 460
    
bool Compiler::eeTryResolveToken(CORINFO_RESOLVED_TOKEN* resolvedToken)
{
    return info.compCompHnd->tryResolveToken(resolvedToken);
}

bool Compiler::eeRunWithErrorTrapImp(void (*function)(void*), void* param)
{
    return info.compCompHnd->runWithErrorTrap(function, param);
}

#endif // CORJIT_EE_VER > 460

/*****************************************************************************
 *
 *                      Utility functions
 */

#if defined(DEBUG) || defined(FEATURE_JIT_METHOD_PERF) || defined(FEATURE_SIMD)

/*****************************************************************************/

// static helper names - constant array
const char* jitHlpFuncTable[CORINFO_HELP_COUNT] =
{
#define JITHELPER(code, pfnHelper, sig)       #code,
#define DYNAMICJITHELPER(code, pfnHelper,sig) #code,
#include "jithelpers.h"
};

/*****************************************************************************
*
*  Filter wrapper to handle exception filtering.
*  On Unix compilers don't support SEH.
*/

struct FilterSuperPMIExceptionsParam_ee_il
{
    Compiler*               pThis;
    Compiler::Info*         pJitInfo;
    CORINFO_FIELD_HANDLE    field;
    CORINFO_METHOD_HANDLE   method;
    CORINFO_CLASS_HANDLE    clazz;
    const char**            classNamePtr;
    const char*             fieldOrMethodOrClassNamePtr;
    EXCEPTION_POINTERS      exceptionPointers;
};

static LONG FilterSuperPMIExceptions_ee_il(PEXCEPTION_POINTERS pExceptionPointers, LPVOID lpvParam)
{
    FilterSuperPMIExceptionsParam_ee_il *pSPMIEParam =
        (FilterSuperPMIExceptionsParam_ee_il *)lpvParam;
    pSPMIEParam->exceptionPointers = *pExceptionPointers;

    if (pSPMIEParam->pThis->IsSuperPMIException(pExceptionPointers->ExceptionRecord->ExceptionCode))
        return EXCEPTION_EXECUTE_HANDLER;
    
    return EXCEPTION_CONTINUE_SEARCH;
}

const char*         Compiler::eeGetMethodName(CORINFO_METHOD_HANDLE       method,
                                              const char** classNamePtr)
{
    if  (eeGetHelperNum(method))
    {
        if (classNamePtr != 0)
            *classNamePtr = "HELPER";

        CorInfoHelpFunc ftnNum = eeGetHelperNum(method);
        const char* name = info.compCompHnd->getHelperName(ftnNum);

        // If it's something unknown from a RET VM, or from SuperPMI, then use our own helper name table.
        if ((strcmp(name, "AnyJITHelper") == 0) ||
            (strcmp(name, "Yickish helper name") == 0))
        {
            if (ftnNum < CORINFO_HELP_COUNT)
            {
                name = jitHlpFuncTable[ftnNum];
            }
        }
        return name;
    }

    if (eeIsNativeMethod(method))
    {
        if (classNamePtr != 0)
            *classNamePtr = "NATIVE";        
        method = eeGetMethodHandleForNative(method);
    }

    FilterSuperPMIExceptionsParam_ee_il param;

    param.pThis = this;
    param.pJitInfo = &info;
    param.method = method;
    param.classNamePtr = classNamePtr;

    PAL_TRY(FilterSuperPMIExceptionsParam_ee_il *, pParam, &param)
    {
        pParam->fieldOrMethodOrClassNamePtr = pParam->pJitInfo->compCompHnd->getMethodName(pParam->method, pParam->classNamePtr);
    }
    PAL_EXCEPT_FILTER(FilterSuperPMIExceptions_ee_il)
    {
        if (param.classNamePtr != nullptr)
        {
            *(param.classNamePtr) = "hackishClassName";
        }

        param.fieldOrMethodOrClassNamePtr = "hackishMethodName";
    }
    PAL_ENDTRY

    return param.fieldOrMethodOrClassNamePtr;
}

const char *        Compiler::eeGetFieldName  (CORINFO_FIELD_HANDLE field,
                                             const char * *     classNamePtr)
{
    FilterSuperPMIExceptionsParam_ee_il param;

    param.pThis = this;
    param.pJitInfo = &info;
    param.field = field;
    param.classNamePtr = classNamePtr;

    PAL_TRY(FilterSuperPMIExceptionsParam_ee_il *, pParam, &param)
    {
        pParam->fieldOrMethodOrClassNamePtr = pParam->pJitInfo->compCompHnd->getFieldName(pParam->field, pParam->classNamePtr);
    }
    PAL_EXCEPT_FILTER(FilterSuperPMIExceptions_ee_il)
    {
        param.fieldOrMethodOrClassNamePtr = "hackishFieldName";
    }
    PAL_ENDTRY

    return param.fieldOrMethodOrClassNamePtr;
}

const char*         Compiler::eeGetClassName(CORINFO_CLASS_HANDLE clsHnd)
{
    FilterSuperPMIExceptionsParam_ee_il param;

    param.pThis = this;
    param.pJitInfo = &info;
    param.clazz = clsHnd;

    PAL_TRY(FilterSuperPMIExceptionsParam_ee_il *, pParam, &param)
    {
        pParam->fieldOrMethodOrClassNamePtr = pParam->pJitInfo->compCompHnd->getClassName(pParam->clazz);
    }
    PAL_EXCEPT_FILTER(FilterSuperPMIExceptions_ee_il)
    {
        param.fieldOrMethodOrClassNamePtr = "hackishClassName";
    }
    PAL_ENDTRY
    return param.fieldOrMethodOrClassNamePtr;
}

#endif // DEBUG || FEATURE_JIT_METHOD_PERF


#ifdef DEBUG

const wchar_t *            Compiler::eeGetCPString (size_t strHandle)
{
    char buff[512 + sizeof(CORINFO_String)];

    // make this bulletproof, so it works even if we are wrong.  
    if (ReadProcessMemory(GetCurrentProcess(), (void*) strHandle, buff, 4, 0) == 0)
        return(0);

    CORINFO_String* asString = *((CORINFO_String**) strHandle);

    if (ReadProcessMemory(GetCurrentProcess(), asString, buff, sizeof(buff), 0) == 0)
        return(0);

    if (asString->stringLen >= 255  || 
        asString->chars[asString->stringLen] != 0   )
    {
        return 0;
    }

    return(asString->chars);
}

#endif // DEBUG
