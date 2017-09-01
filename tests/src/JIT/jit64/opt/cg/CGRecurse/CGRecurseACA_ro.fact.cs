using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_CGRecurse_CGRecurseACA_ro_CGRecurseACA_ro_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseACA_ro_CGRecurseACA_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseACA_ro\\CGRecurseACA_ro.cmd");
        }
    }
}
