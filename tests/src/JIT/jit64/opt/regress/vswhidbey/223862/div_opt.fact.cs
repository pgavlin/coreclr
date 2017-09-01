using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_223862_div_opt_div_opt_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_223862_div_opt_div_opt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\div_opt\\div_opt.cmd");
        }
    }
}
