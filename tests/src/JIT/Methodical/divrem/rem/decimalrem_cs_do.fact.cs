using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_decimalrem_cs_do_decimalrem_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_decimalrem_cs_do_decimalrem_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\decimalrem_cs_do\\decimalrem_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
