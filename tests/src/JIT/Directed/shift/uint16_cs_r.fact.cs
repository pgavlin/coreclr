using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint16_cs_r_uint16_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_cs_r_uint16_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_cs_r\\uint16_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
