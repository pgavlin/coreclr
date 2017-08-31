using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int16_r_int16_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_r_int16_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_r\\int16_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
