using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_decimaldiv_cs_d_decimaldiv_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_decimaldiv_cs_d_decimaldiv_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\decimaldiv_cs_d\\decimaldiv_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
