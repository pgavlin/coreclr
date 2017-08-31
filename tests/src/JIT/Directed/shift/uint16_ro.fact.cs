using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint16_ro_uint16_ro_
    {
        [Fact]
        public void _shift_uint16_ro_uint16_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_ro\\uint16_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
