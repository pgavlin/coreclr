using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_commutativecse_ccse_cs_do_ccse_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_commutativecse_ccse_cs_do_ccse_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\commutativecse\\ccse_cs_do\\ccse_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
