using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_staticFieldExprUnchecked1_r_loop_staticFieldExprUnchecked1_r_loop_
    {
        [Fact]
        public void _opt_cse_staticFieldExprUnchecked1_r_loop_staticFieldExprUnchecked1_r_loop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExprUnchecked1_r_loop\\staticFieldExprUnchecked1_r_loop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
