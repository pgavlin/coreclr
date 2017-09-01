using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cg_il_jmp_impl_jmp_impl_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_jmp_impl_jmp_impl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\jmp_impl\\jmp_impl.cmd");
        }
    }
}
