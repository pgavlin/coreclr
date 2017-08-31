using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_il_ldftn_dbg_ldftn_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_ldftn_dbg_ldftn_dbg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\ldftn_dbg\\ldftn_dbg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
