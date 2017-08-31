using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_FractalPerf_FractalPerf_FractalPerf_
    {
        [Fact]
        public void _CodeQuality_FractalPerf_FractalPerf_FractalPerf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\FractalPerf\\FractalPerf\\FractalPerf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
