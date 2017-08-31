using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_Midpoint_Midpoint_Midpoint_
    {
        [Fact]
        public void _CodeQuality_BenchI_Midpoint_Midpoint_Midpoint_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\Midpoint\\Midpoint\\Midpoint.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
