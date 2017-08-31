using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_osr_osr015_osr015_
    {
        [Fact]
        public void _opt_osr_osr015_osr015_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\osr\\osr015\\osr015.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
