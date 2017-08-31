using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint8_d_uint8_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_d_uint8_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_d\\uint8_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
