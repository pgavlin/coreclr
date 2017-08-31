using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_gc_GCMaxGeneration_GCMaxGeneration_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCMaxGeneration_GCMaxGeneration_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCMaxGeneration\\GCMaxGeneration.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
