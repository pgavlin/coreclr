using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_regress_vswhidbey_223862_div_dbg_div_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_223862_div_dbg_div_dbg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\div_dbg\\div_dbg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
