using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_staticFieldExpr1_ro_loop_staticFieldExpr1_ro_loop_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_staticFieldExpr1_ro_loop_staticFieldExpr1_ro_loop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExpr1_ro_loop\\staticFieldExpr1_ro_loop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
