using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_compilerservices_runtimehelpers_GetHashCode_GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_compilerservices_runtimehelpers_GetHashCode_GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\compilerservices\\runtimehelpers\\GetHashCode\\GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
