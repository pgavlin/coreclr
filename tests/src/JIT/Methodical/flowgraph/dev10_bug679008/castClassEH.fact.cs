using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679008_castClassEH_castClassEH_
    {
        [Fact]
        public void _flowgraph_dev10_bug679008_castClassEH_castClassEH_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\castClassEH\\castClassEH.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
