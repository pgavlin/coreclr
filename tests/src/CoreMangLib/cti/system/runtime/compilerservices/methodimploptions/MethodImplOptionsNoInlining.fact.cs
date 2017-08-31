using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_methodimploptions_MethodImplOptionsNoInlining_MethodImplOptionsNoInlining_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_methodimploptions_MethodImplOptionsNoInlining_MethodImplOptionsNoInlining_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\methodimploptions\\MethodImplOptionsNoInlining\\MethodImplOptionsNoInlining.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
