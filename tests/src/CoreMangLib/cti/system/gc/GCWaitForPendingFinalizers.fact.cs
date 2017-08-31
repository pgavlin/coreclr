using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_gc_GCWaitForPendingFinalizers_GCWaitForPendingFinalizers_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCWaitForPendingFinalizers_GCWaitForPendingFinalizers_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCWaitForPendingFinalizers\\GCWaitForPendingFinalizers.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
