using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_fieldExprUnchecked1_fieldExprUnchecked1_
    {
        [Fact]
        public void _opt_cse_fieldExprUnchecked1_fieldExprUnchecked1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\fieldExprUnchecked1\\fieldExprUnchecked1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
