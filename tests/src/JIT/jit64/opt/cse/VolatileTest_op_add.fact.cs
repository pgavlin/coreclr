using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_VolatileTest_op_add_VolatileTest_op_add_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_add_VolatileTest_op_add_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_add\\VolatileTest_op_add.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
