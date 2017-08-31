using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_ArrayWithFunc_o_ArrayWithFunc_o_
    {
        [Fact]
        public void _opt_rngchk_ArrayWithFunc_o_ArrayWithFunc_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\ArrayWithFunc_o\\ArrayWithFunc_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
