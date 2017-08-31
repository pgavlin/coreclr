using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679008_GCOverReporting_GCOverReporting_
    {
        [Fact]
        public void _flowgraph_dev10_bug679008_GCOverReporting_GCOverReporting_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\GCOverReporting\\GCOverReporting.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
