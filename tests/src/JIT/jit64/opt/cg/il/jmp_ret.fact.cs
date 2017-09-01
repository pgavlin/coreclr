using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_il_jmp_ret_jmp_ret_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_jmp_ret_jmp_ret_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\jmp_ret\\jmp_ret.cmd");
        }
    }
}
