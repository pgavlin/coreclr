using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Roslyn_CscBench_CscBench_
    {
        [Fact]
        public void _CodeQuality_Roslyn_CscBench_CscBench_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Roslyn\\CscBench\\CscBench.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
