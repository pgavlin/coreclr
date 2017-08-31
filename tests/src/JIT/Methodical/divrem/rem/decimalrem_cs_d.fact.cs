using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_decimalrem_cs_d_decimalrem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_decimalrem_cs_d_decimalrem_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\decimalrem_cs_d\\decimalrem_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
