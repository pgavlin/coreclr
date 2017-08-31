using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_methodimploptions_MethodImplOptionsPreserveSig_MethodImplOptionsPreserveSig_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_methodimploptions_MethodImplOptionsPreserveSig_MethodImplOptionsPreserveSig_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\methodimploptions\\MethodImplOptionsPreserveSig\\MethodImplOptionsPreserveSig.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
