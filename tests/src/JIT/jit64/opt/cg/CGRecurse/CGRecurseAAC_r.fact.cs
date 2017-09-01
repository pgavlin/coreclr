using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_CGRecurse_CGRecurseAAC_r_CGRecurseAAC_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseAAC_r_CGRecurseAAC_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseAAC_r\\CGRecurseAAC_r.cmd");
        }
    }
}
