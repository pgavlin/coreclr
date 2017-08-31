using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_BubbleSort_BubbleSort_BubbleSort_
    {
        [Fact]
        public void _CodeQuality_BenchI_BubbleSort_BubbleSort_BubbleSort_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\BubbleSort\\BubbleSort\\BubbleSort.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
