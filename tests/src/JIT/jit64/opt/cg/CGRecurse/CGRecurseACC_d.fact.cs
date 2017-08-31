using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_CGRecurse_CGRecurseACC_d_CGRecurseACC_d_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseACC_d_CGRecurseACC_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseACC_d\\CGRecurseACC_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
