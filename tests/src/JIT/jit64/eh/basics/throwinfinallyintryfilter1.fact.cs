using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_basics_throwinfinallyintryfilter1_throwinfinallyintryfilter1_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter1_throwinfinallyintryfilter1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\basics\\throwinfinallyintryfilter1\\throwinfinallyintryfilter1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
