using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679053_flowgraph_flowgraph_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679053_flowgraph_flowgraph_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679053\\flowgraph\\flowgraph.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
