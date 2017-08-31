using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_flowgraph_xaddmuly_cs_r_xaddmuly_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_flowgraph_xaddmuly_cs_r_xaddmuly_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\flowgraph\\xaddmuly_cs_r\\xaddmuly_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
