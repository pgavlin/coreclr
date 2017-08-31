using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyintryfilter2_r_throwinfinallyintryfilter2_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter2_r_throwinfinallyintryfilter2_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyintryfilter2_r\\throwinfinallyintryfilter2_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
