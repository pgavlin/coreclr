using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_MatrixMul_o_MatrixMul_o_
    {
        [OuterLoop]
        [Fact]
        public void _opt_rngchk_MatrixMul_o_MatrixMul_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\MatrixMul_o\\MatrixMul_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
