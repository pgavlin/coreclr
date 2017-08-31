using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_hugeSimpleExpr1_hugeSimpleExpr1_
    {
        [Fact]
        public void _opt_cse_hugeSimpleExpr1_hugeSimpleExpr1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\hugeSimpleExpr1\\hugeSimpleExpr1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
