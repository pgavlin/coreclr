using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_pidigits_pi_digits_pi_digits_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_pidigits_pi_digits_pi_digits_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\pidigits\\pi-digits\\pi-digits.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
