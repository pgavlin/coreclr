using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_VolatileTest_op_mod_VolatileTest_op_mod_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_VolatileTest_op_mod_VolatileTest_op_mod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\VolatileTest_op_mod\\VolatileTest_op_mod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
