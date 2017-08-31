using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_r8div_cs_do_r8div_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_r8div_cs_do_r8div_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\r8div_cs_do\\r8div_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
