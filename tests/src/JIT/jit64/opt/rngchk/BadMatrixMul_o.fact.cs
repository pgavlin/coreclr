using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_BadMatrixMul_o_BadMatrixMul_o_
    {
        [Fact]
        public void _opt_rngchk_BadMatrixMul_o_BadMatrixMul_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\BadMatrixMul_o\\BadMatrixMul_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
