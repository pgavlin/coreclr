using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_arrayexpr2_d_loop_try_arrayexpr2_d_loop_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_arrayexpr2_d_loop_try_arrayexpr2_d_loop_try_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\arrayexpr2_d_loop_try\\arrayexpr2_d_loop_try.cmd");
        }
    }
}
