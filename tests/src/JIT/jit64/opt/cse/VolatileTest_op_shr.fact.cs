using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_VolatileTest_op_shr_VolatileTest_op_shr_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_shr_VolatileTest_op_shr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_shr\\VolatileTest_op_shr.cmd");
        }
    }
}
