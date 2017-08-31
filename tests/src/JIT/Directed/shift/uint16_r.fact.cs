using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint16_r_uint16_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_r_uint16_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_r\\uint16_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
