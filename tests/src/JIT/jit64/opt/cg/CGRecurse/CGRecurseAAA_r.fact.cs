using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_CGRecurse_CGRecurseAAA_r_CGRecurseAAA_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseAAA_r_CGRecurseAAA_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseAAA_r\\CGRecurseAAA_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
