using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_VolatileTest_op_and_VolatileTest_op_and_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_and_VolatileTest_op_and_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_and\\VolatileTest_op_and.cmd");
        }
    }
}
