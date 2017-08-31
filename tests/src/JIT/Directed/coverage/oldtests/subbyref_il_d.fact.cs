using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_subbyref_il_d_subbyref_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_subbyref_il_d_subbyref_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\subbyref_il_d\\subbyref_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
