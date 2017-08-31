using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_il_jmp_dbg_jmp_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_jmp_dbg_jmp_dbg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\jmp_dbg\\jmp_dbg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
