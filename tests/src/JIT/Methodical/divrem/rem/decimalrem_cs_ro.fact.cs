using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_decimalrem_cs_ro_decimalrem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_decimalrem_cs_ro_decimalrem_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\decimalrem_cs_ro\\decimalrem_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
