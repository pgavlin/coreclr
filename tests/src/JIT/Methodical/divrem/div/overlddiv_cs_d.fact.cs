using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_overlddiv_cs_d_overlddiv_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_overlddiv_cs_d_overlddiv_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\overlddiv_cs_d\\overlddiv_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
