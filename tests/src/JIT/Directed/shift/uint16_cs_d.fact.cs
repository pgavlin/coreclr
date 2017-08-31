using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint16_cs_d_uint16_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_cs_d_uint16_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_cs_d\\uint16_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
