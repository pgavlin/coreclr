using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int16_cs_do_int16_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_cs_do_int16_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_cs_do\\int16_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
