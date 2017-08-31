using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_Ackermann_Ackermann_Ackermann_
    {
        [Fact]
        public void _CodeQuality_BenchI_Ackermann_Ackermann_Ackermann_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\Ackermann\\Ackermann\\Ackermann.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
