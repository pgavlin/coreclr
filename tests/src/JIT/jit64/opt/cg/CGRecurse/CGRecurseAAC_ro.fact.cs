using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_CGRecurse_CGRecurseAAC_ro_CGRecurseAAC_ro_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseAAC_ro_CGRecurseAAC_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseAAC_ro\\CGRecurseAAC_ro.cmd");
        }
    }
}
