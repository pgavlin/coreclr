using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_QuickSort_QuickSort_QuickSort_
    {
        [Fact]
        public void _CodeQuality_BenchI_QuickSort_QuickSort_QuickSort_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\QuickSort\\QuickSort\\QuickSort.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
