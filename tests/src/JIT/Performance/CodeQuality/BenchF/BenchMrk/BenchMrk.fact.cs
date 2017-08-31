using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_BenchMrk_BenchMrk_BenchMrk_
    {
        [Fact]
        public void _CodeQuality_BenchF_BenchMrk_BenchMrk_BenchMrk_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\BenchMrk\\BenchMrk\\BenchMrk.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
