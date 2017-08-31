using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_BenchE_BenchE_BenchE_
    {
        [Fact]
        public void _CodeQuality_BenchI_BenchE_BenchE_BenchE_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\BenchE\\BenchE\\BenchE.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
