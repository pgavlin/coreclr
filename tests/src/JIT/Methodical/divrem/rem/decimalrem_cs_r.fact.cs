using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_decimalrem_cs_r_decimalrem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_decimalrem_cs_r_decimalrem_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\decimalrem_cs_r\\decimalrem_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
