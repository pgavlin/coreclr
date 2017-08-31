using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_flowgraph_xaddmuly_cs_d_xaddmuly_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_flowgraph_xaddmuly_cs_d_xaddmuly_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\flowgraph\\xaddmuly_cs_d\\xaddmuly_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
