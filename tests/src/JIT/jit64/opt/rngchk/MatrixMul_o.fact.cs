using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_rngchk_MatrixMul_o_MatrixMul_o_
    {
        [OuterLoop]
        [Fact]
        public void _opt_rngchk_MatrixMul_o_MatrixMul_o_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\MatrixMul_o\\MatrixMul_o.cmd");
        }
    }
}
