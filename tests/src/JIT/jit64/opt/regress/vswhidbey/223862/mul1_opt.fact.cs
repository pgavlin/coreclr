using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_223862_mul1_opt_mul1_opt_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_223862_mul1_opt_mul1_opt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\mul1_opt\\mul1_opt.cmd");
        }
    }
}
