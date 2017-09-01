using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_arrayexpr2_r_loop_arrayexpr2_r_loop_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_arrayexpr2_r_loop_arrayexpr2_r_loop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\arrayexpr2_r_loop\\arrayexpr2_r_loop.cmd");
        }
    }
}
