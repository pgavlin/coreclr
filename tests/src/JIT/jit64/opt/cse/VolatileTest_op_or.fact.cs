using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_VolatileTest_op_or_VolatileTest_op_or_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_or_VolatileTest_op_or_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_or\\VolatileTest_op_or.cmd");
        }
    }
}
