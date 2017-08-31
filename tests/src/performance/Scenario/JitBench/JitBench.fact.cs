using CoreclrTestLib;
using Xunit;

namespace performance_Scenario
{
    class _JitBench_JitBench_JitBench_
    {
        [Fact]
        public void _JitBench_JitBench_JitBench_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("performance\\Scenario\\JitBench\\JitBench\\JitBench.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
