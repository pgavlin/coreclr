using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_staticFieldExprUnchecked1_r_staticFieldExprUnchecked1_r_
    {
        [Fact]
        public void _opt_cse_staticFieldExprUnchecked1_r_staticFieldExprUnchecked1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExprUnchecked1_r\\staticFieldExprUnchecked1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
