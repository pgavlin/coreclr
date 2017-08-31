using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_8Queens_8Queens_8Queens_
    {
        [Fact]
        public void _CodeQuality_BenchI_8Queens_8Queens_8Queens_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\8Queens\\8Queens\\8Queens.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
