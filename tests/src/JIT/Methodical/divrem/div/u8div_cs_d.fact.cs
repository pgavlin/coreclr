using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_u8div_cs_d_u8div_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_u8div_cs_d_u8div_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\u8div_cs_d\\u8div_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
