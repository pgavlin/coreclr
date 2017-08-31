using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_overlddiv_cs_r_overlddiv_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_overlddiv_cs_r_overlddiv_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\overlddiv_cs_r\\overlddiv_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
