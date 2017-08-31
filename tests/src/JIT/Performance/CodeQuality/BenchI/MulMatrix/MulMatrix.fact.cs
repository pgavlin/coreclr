using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_MulMatrix_MulMatrix_MulMatrix_
    {
        [Fact]
        public void _CodeQuality_BenchI_MulMatrix_MulMatrix_MulMatrix_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\MulMatrix\\MulMatrix\\MulMatrix.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
