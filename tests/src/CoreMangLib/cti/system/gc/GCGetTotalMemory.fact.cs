using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_gc_GCGetTotalMemory_GCGetTotalMemory_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCGetTotalMemory_GCGetTotalMemory_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCGetTotalMemory\\GCGetTotalMemory.cmd");
        }
    }
}
