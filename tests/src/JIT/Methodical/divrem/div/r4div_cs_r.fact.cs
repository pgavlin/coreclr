using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_r4div_cs_r_r4div_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_r4div_cs_r_r4div_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\r4div_cs_r\\r4div_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
