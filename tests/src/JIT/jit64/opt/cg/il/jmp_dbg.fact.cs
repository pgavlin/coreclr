using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_il_jmp_dbg_jmp_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_jmp_dbg_jmp_dbg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\jmp_dbg\\jmp_dbg.cmd");
        }
    }
}
