using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_il_ldftn_ret_ldftn_ret_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_ldftn_ret_ldftn_ret_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\ldftn_ret\\ldftn_ret.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
