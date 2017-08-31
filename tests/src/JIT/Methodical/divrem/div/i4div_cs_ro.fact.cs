using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_i4div_cs_ro_i4div_cs_ro_
    {
        [Fact]
        public void _divrem_div_i4div_cs_ro_i4div_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\i4div_cs_ro\\i4div_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
