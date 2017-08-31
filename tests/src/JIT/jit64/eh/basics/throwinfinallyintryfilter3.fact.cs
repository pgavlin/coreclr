using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_basics_throwinfinallyintryfilter3_throwinfinallyintryfilter3_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyintryfilter3_throwinfinallyintryfilter3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\basics\\throwinfinallyintryfilter3\\throwinfinallyintryfilter3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
