using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_VolatileTest_op_mul_VolatileTest_op_mul_
    {
        [Fact]
        public void _opt_cse_VolatileTest_op_mul_VolatileTest_op_mul_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_mul\\VolatileTest_op_mul.cmd");
        }
    }
}
