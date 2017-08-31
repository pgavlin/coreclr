using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint8_cs_ro_uint8_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_cs_ro_uint8_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_cs_ro\\uint8_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
