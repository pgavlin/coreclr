using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_basics_throwinfinallyintryfilter2_throwinfinallyintryfilter2_
    {
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter2_throwinfinallyintryfilter2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\basics\\throwinfinallyintryfilter2\\throwinfinallyintryfilter2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
