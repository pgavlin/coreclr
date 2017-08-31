using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_u4div_cs_do_u4div_cs_do_
    {
        [Fact]
        public void _divrem_div_u4div_cs_do_u4div_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\u4div_cs_do\\u4div_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
