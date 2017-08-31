using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _rtchecks_overflow_overflow03_sub_overflow03_sub_
    {
        [Fact]
        public void _rtchecks_overflow_overflow03_sub_overflow03_sub_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow03_sub\\overflow03_sub.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
