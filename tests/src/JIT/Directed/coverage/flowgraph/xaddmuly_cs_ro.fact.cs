using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_flowgraph_xaddmuly_cs_ro_xaddmuly_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_flowgraph_xaddmuly_cs_ro_xaddmuly_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\flowgraph\\xaddmuly_cs_ro\\xaddmuly_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
