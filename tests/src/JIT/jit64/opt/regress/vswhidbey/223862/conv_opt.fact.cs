using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_regress_vswhidbey_223862_conv_opt_conv_opt_
    {
        [Fact]
        public void _opt_regress_vswhidbey_223862_conv_opt_conv_opt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\conv_opt\\conv_opt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
