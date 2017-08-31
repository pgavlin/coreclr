using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_Permutate_Permutate_Permutate_
    {
        [Fact]
        public void _CodeQuality_BenchI_Permutate_Permutate_Permutate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\Permutate\\Permutate\\Permutate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
