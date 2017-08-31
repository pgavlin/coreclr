using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_layoutkind_LayoutKindSequential_LayoutKindSequential_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_layoutkind_LayoutKindSequential_LayoutKindSequential_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\layoutkind\\LayoutKindSequential\\LayoutKindSequential.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
