using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _rtchecks_overflow_overflow04_sub_overflow04_sub_
    {
        [Fact]
        public void _rtchecks_overflow_overflow04_sub_overflow04_sub_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow04_sub\\overflow04_sub.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
