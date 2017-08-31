using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_CGRecurse_CGRecurseACA_r_CGRecurseACA_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseACA_r_CGRecurseACA_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseACA_r\\CGRecurseACA_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
