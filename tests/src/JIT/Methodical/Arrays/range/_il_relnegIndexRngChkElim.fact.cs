using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_relnegIndexRngChkElim__il_relnegIndexRngChkElim_
    {
        [Fact]
        public void _Arrays_range__il_relnegIndexRngChkElim__il_relnegIndexRngChkElim_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_relnegIndexRngChkElim\\_il_relnegIndexRngChkElim.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
