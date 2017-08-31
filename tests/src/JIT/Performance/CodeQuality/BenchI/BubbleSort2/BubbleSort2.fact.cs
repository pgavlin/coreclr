using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_BubbleSort2_BubbleSort2_BubbleSort2_
    {
        [Fact]
        public void _CodeQuality_BenchI_BubbleSort2_BubbleSort2_BubbleSort2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\BubbleSort2\\BubbleSort2\\BubbleSort2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
