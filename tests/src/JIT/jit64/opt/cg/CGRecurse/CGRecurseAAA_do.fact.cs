using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_CGRecurse_CGRecurseAAA_do_CGRecurseAAA_do_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseAAA_do_CGRecurseAAA_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseAAA_do\\CGRecurseAAA_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
