using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_regress_vswhidbey_223862_rem_opt_rem_opt_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_223862_rem_opt_rem_opt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\rem_opt\\rem_opt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
