using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_fastaredux_fastaredux_fastaredux_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_fastaredux_fastaredux_fastaredux_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\fastaredux\\fastaredux\\fastaredux.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
