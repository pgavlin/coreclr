using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_CGRecurse_CGRecurseACC_ro_CGRecurseACC_ro_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_CGRecurse_CGRecurseACC_ro_CGRecurseACC_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\CGRecurse\\CGRecurseACC_ro\\CGRecurseACC_ro.cmd");
        }
    }
}
