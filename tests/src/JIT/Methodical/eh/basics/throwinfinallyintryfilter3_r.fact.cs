using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyintryfilter3_r_throwinfinallyintryfilter3_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter3_r_throwinfinallyintryfilter3_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyintryfilter3_r\\throwinfinallyintryfilter3_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
