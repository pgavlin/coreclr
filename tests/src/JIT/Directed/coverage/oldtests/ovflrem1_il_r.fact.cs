using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_ovflrem1_il_r_ovflrem1_il_r_
    {
        [Fact]
        public void _coverage_oldtests_ovflrem1_il_r_ovflrem1_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\ovflrem1_il_r\\ovflrem1_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
