using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _rtchecks_overflow_overflow02_div_overflow02_div_
    {
        [Fact]
        public void _rtchecks_overflow_overflow02_div_overflow02_div_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow02_div\\overflow02_div.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
