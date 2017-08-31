using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_r8div_cs_ro_r8div_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_r8div_cs_ro_r8div_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\r8div_cs_ro\\r8div_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
