using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_BenchI_MulMatrix_MulMatrix_MulMatrix_
    {
        [Fact]
        public void _CodeQuality_BenchI_MulMatrix_MulMatrix_MulMatrix_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\MulMatrix\\MulMatrix\\MulMatrix.cmd");
        }
    }
}
