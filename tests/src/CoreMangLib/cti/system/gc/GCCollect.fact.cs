using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_gc_GCCollect_GCCollect_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCCollect_GCCollect_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCCollect\\GCCollect.cmd");
        }
    }
}
