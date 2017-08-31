using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyintryfilter1_r_throwinfinallyintryfilter1_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter1_r_throwinfinallyintryfilter1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyintryfilter1_r\\throwinfinallyintryfilter1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
