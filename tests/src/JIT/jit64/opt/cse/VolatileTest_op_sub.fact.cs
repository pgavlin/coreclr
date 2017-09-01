using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_VolatileTest_op_sub_VolatileTest_op_sub_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_sub_VolatileTest_op_sub_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_sub\\VolatileTest_op_sub.cmd");
        }
    }
}
