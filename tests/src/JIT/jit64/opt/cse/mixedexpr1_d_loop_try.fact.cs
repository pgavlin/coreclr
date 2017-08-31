using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_mixedexpr1_d_loop_try_mixedexpr1_d_loop_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_mixedexpr1_d_loop_try_mixedexpr1_d_loop_try_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\mixedexpr1_d_loop_try\\mixedexpr1_d_loop_try.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
