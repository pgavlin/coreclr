using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_CSieve_CSieve_CSieve_
    {
        [Fact]
        public void _CodeQuality_BenchI_CSieve_CSieve_CSieve_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\CSieve\\CSieve\\CSieve.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
