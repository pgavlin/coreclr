using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_switchdefaultonly2_il_d_switchdefaultonly2_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_switchdefaultonly2_il_d_switchdefaultonly2_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\switchdefaultonly2_il_d\\switchdefaultonly2_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
