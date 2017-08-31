using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_gc_GCKeepAlive_GCKeepAlive_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCKeepAlive_GCKeepAlive_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCKeepAlive\\GCKeepAlive.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
