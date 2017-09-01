using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_gc_GCKeepAlive_GCKeepAlive_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCKeepAlive_GCKeepAlive_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCKeepAlive\\GCKeepAlive.cmd");
        }
    }
}
