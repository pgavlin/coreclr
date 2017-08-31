using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_switchdefaultonly3_il_r_switchdefaultonly3_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_switchdefaultonly3_il_r_switchdefaultonly3_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\switchdefaultonly3_il_r\\switchdefaultonly3_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
