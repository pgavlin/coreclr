using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_volatilecpobj_il_r_volatilecpobj_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_volatilecpobj_il_r_volatilecpobj_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\volatilecpobj_il_r\\volatilecpobj_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
