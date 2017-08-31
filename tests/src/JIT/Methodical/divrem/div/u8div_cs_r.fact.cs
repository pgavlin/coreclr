using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_u8div_cs_r_u8div_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_u8div_cs_r_u8div_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\u8div_cs_r\\u8div_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
