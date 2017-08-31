using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_SIMD_ConsoleMandel_ConsoleMandel_ConsoleMandel_
    {
        [Fact]
        public void _CodeQuality_SIMD_ConsoleMandel_ConsoleMandel_ConsoleMandel_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\SIMD\\ConsoleMandel\\ConsoleMandel\\ConsoleMandel.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
