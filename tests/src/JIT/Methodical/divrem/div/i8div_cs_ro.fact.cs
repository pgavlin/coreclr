using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_i8div_cs_ro_i8div_cs_ro_
    {
        [Fact]
        public void _divrem_div_i8div_cs_ro_i8div_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\i8div_cs_ro\\i8div_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
