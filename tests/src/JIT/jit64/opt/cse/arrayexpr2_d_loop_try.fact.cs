using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_arrayexpr2_d_loop_try_arrayexpr2_d_loop_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_arrayexpr2_d_loop_try_arrayexpr2_d_loop_try_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\arrayexpr2_d_loop_try\\arrayexpr2_d_loop_try.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
