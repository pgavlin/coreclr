using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _rtchecks_overflow_overflow04_div_overflow04_div_
    {
        [Fact]
        public void _rtchecks_overflow_overflow04_div_overflow04_div_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow04_div\\overflow04_div.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
