using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_u8div_cs_do_u8div_cs_do_
    {
        [Fact]
        public void _divrem_div_u8div_cs_do_u8div_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\u8div_cs_do\\u8div_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
