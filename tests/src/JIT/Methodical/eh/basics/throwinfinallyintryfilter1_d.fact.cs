using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyintryfilter1_d_throwinfinallyintryfilter1_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter1_d_throwinfinallyintryfilter1_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyintryfilter1_d\\throwinfinallyintryfilter1_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
