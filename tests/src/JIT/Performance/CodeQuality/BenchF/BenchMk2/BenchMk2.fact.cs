using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_BenchMk2_BenchMk2_BenchMk2_
    {
        [Fact]
        public void _CodeQuality_BenchF_BenchMk2_BenchMk2_BenchMk2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\BenchMk2\\BenchMk2\\BenchMk2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
