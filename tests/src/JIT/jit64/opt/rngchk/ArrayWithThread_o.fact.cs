using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_ArrayWithThread_o_ArrayWithThread_o_
    {
        [Fact]
        public void _opt_rngchk_ArrayWithThread_o_ArrayWithThread_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\ArrayWithThread_o\\ArrayWithThread_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
