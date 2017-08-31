using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_ldfldstatic_il_d_ldfldstatic_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_ldfldstatic_il_d_ldfldstatic_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\ldfldstatic_il_d\\ldfldstatic_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
