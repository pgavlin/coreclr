using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_flowgraph_xaddmuly_cs_do_xaddmuly_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_flowgraph_xaddmuly_cs_do_xaddmuly_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\flowgraph\\xaddmuly_cs_do\\xaddmuly_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
