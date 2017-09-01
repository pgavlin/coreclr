using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_il_ldftn_dbg_ldftn_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_ldftn_dbg_ldftn_dbg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\ldftn_dbg\\ldftn_dbg.cmd");
        }
    }
}
