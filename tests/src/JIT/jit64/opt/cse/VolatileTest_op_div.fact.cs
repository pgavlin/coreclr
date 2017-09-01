using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_VolatileTest_op_div_VolatileTest_op_div_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_div_VolatileTest_op_div_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_div\\VolatileTest_op_div.cmd");
        }
    }
}
