using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_ovflrem2_il_r_ovflrem2_il_r_
    {
        [Fact]
        public void _coverage_oldtests_ovflrem2_il_r_ovflrem2_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\ovflrem2_il_r\\ovflrem2_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
