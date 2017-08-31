using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_JaggedArray_o_JaggedArray_o_
    {
        [Fact]
        public void _opt_rngchk_JaggedArray_o_JaggedArray_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\JaggedArray_o\\JaggedArray_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
