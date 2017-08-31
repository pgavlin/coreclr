using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_mandelbrot_mandelbrot_mandelbrot_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_mandelbrot_mandelbrot_mandelbrot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\mandelbrot\\mandelbrot\\mandelbrot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
