using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int16_d_int16_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_d_int16_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_d\\int16_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
