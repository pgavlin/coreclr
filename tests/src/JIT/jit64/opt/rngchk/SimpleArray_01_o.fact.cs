using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_SimpleArray_01_o_SimpleArray_01_o_
    {
        [Fact]
        public void _opt_rngchk_SimpleArray_01_o_SimpleArray_01_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\SimpleArray_01_o\\SimpleArray_01_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
