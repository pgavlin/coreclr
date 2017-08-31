using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug675304_loopIV_init_loopIV_init_
    {
        [Fact]
        public void _flowgraph_dev10_bug675304_loopIV_init_loopIV_init_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug675304\\loopIV_init\\loopIV_init.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
