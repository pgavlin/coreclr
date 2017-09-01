using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_CGRecurse_CGRecurseAAA_r_CGRecurseAAA_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseAAA_r_CGRecurseAAA_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseAAA_r\\CGRecurseAAA_r.cmd");
        }
    }
}
