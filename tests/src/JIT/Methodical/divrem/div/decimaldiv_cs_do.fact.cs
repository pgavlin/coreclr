using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_decimaldiv_cs_do_decimaldiv_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_decimaldiv_cs_do_decimaldiv_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\decimaldiv_cs_do\\decimaldiv_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
