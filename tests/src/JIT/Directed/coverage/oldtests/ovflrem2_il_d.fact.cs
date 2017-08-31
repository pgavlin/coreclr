using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_ovflrem2_il_d_ovflrem2_il_d_
    {
        [Fact]
        public void _coverage_oldtests_ovflrem2_il_d_ovflrem2_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\ovflrem2_il_d\\ovflrem2_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
