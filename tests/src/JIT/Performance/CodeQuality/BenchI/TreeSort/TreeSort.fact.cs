using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_TreeSort_TreeSort_TreeSort_
    {
        [Fact]
        public void _CodeQuality_BenchI_TreeSort_TreeSort_TreeSort_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\TreeSort\\TreeSort\\TreeSort.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
