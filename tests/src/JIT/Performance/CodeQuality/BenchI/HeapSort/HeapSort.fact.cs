using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_HeapSort_HeapSort_HeapSort_
    {
        [Fact]
        public void _CodeQuality_BenchI_HeapSort_HeapSort_HeapSort_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\HeapSort\\HeapSort\\HeapSort.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
