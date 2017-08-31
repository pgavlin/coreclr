using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_staticFieldExpr1_r_loop_try_staticFieldExpr1_r_loop_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_staticFieldExpr1_r_loop_try_staticFieldExpr1_r_loop_try_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExpr1_r_loop_try\\staticFieldExpr1_r_loop_try.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
