using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_223862_bne_dbg_bne_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_223862_bne_dbg_bne_dbg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\bne_dbg\\bne_dbg.cmd");
        }
    }
}
