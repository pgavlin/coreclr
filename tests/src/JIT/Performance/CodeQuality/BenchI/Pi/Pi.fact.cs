using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_Pi_Pi_Pi_
    {
        [Fact]
        public void _CodeQuality_BenchI_Pi_Pi_Pi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\Pi\\Pi\\Pi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
