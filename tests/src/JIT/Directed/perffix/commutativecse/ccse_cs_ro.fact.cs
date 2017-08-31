using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_commutativecse_ccse_cs_ro_ccse_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_commutativecse_ccse_cs_ro_ccse_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\commutativecse\\ccse_cs_ro\\ccse_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
