using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyintryfilter3_d_throwinfinallyintryfilter3_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter3_d_throwinfinallyintryfilter3_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyintryfilter3_d\\throwinfinallyintryfilter3_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
