using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_Lorenz_Lorenz_Lorenz_
    {
        [Fact]
        public void _CodeQuality_BenchF_Lorenz_Lorenz_Lorenz_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\Lorenz\\Lorenz\\Lorenz.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
