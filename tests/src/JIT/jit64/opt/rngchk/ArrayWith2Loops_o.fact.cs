using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_ArrayWith2Loops_o_ArrayWith2Loops_o_
    {
        [Fact]
        public void _opt_rngchk_ArrayWith2Loops_o_ArrayWith2Loops_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\ArrayWith2Loops_o\\ArrayWith2Loops_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
