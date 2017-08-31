using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int8_il_r_int8_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int8_il_r_int8_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int8_il_r\\int8_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
