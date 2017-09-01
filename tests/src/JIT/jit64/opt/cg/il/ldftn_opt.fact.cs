using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_il_ldftn_opt_ldftn_opt_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_ldftn_opt_ldftn_opt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\ldftn_opt\\ldftn_opt.cmd");
        }
    }
}
