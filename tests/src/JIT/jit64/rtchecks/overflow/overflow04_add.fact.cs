using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _rtchecks_overflow_overflow04_add_overflow04_add_
    {
        [Fact]
        public void _rtchecks_overflow_overflow04_add_overflow04_add_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow04_add\\overflow04_add.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
