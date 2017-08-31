using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_overlddiv_cs_ro_overlddiv_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_overlddiv_cs_ro_overlddiv_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\overlddiv_cs_ro\\overlddiv_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
