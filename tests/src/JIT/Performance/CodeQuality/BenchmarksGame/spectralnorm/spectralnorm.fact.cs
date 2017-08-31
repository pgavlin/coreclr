using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_spectralnorm_spectralnorm_spectralnorm_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_spectralnorm_spectralnorm_spectralnorm_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\spectralnorm\\spectralnorm\\spectralnorm.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
