using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_gc_GCGetTotalMemory_GCGetTotalMemory_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCGetTotalMemory_GCGetTotalMemory_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCGetTotalMemory\\GCGetTotalMemory.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
