using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_VolatileTest_op_xor_VolatileTest_op_xor_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_xor_VolatileTest_op_xor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_xor\\VolatileTest_op_xor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
