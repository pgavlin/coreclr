using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint8_ro_uint8_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_ro_uint8_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_ro\\uint8_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
