using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint8_cs_do_uint8_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_cs_do_uint8_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_cs_do\\uint8_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
