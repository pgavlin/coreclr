using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_decimaldiv_cs_r_decimaldiv_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_decimaldiv_cs_r_decimaldiv_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\decimaldiv_cs_r\\decimaldiv_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
