using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_gc_GCMaxGeneration_GCMaxGeneration_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCMaxGeneration_GCMaxGeneration_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCMaxGeneration\\GCMaxGeneration.cmd");
        }
    }
}
