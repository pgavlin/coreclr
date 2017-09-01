using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_223862_bne_opt_bne_opt_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_223862_bne_opt_bne_opt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\bne_opt\\bne_opt.cmd");
        }
    }
}
