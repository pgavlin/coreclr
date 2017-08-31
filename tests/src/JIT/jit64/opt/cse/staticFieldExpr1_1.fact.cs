using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_staticFieldExpr1_1_staticFieldExpr1_1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_staticFieldExpr1_1_staticFieldExpr1_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExpr1_1\\staticFieldExpr1_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
