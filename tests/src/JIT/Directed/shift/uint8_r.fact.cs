using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint8_r_uint8_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_r_uint8_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_r\\uint8_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
