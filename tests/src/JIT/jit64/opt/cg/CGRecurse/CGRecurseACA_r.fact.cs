using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_CGRecurse_CGRecurseACA_r_CGRecurseACA_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseACA_r_CGRecurseACA_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseACA_r\\CGRecurseACA_r.cmd");
        }
    }
}
