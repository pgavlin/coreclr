using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _perf_doublealign_Arrays_Arrays_
    {
        [Fact]
        public void _perf_doublealign_Arrays_Arrays_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\perf\\doublealign\\Arrays\\Arrays.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
