using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_staticFieldExprUnchecked1_r_loop_try_staticFieldExprUnchecked1_r_loop_try_
    {
        [Fact]
        public void _opt_cse_staticFieldExprUnchecked1_r_loop_try_staticFieldExprUnchecked1_r_loop_try_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExprUnchecked1_r_loop_try\\staticFieldExprUnchecked1_r_loop_try.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
