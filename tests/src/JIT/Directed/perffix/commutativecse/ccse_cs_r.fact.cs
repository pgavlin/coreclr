using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_commutativecse_ccse_cs_r_ccse_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_commutativecse_ccse_cs_r_ccse_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\commutativecse\\ccse_cs_r\\ccse_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
