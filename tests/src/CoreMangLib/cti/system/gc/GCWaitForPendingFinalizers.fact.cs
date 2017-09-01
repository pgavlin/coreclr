using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_gc_GCWaitForPendingFinalizers_GCWaitForPendingFinalizers_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCWaitForPendingFinalizers_GCWaitForPendingFinalizers_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCWaitForPendingFinalizers\\GCWaitForPendingFinalizers.cmd");
        }
    }
}
