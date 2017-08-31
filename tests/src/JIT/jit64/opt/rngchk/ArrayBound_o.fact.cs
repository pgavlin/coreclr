using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_ArrayBound_o_ArrayBound_o_
    {
        [Fact]
        public void _opt_rngchk_ArrayBound_o_ArrayBound_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\ArrayBound_o\\ArrayBound_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
