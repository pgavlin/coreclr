using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_RngchkStress1_o_RngchkStress1_o_
    {
        [Fact]
        public void _opt_rngchk_RngchkStress1_o_RngchkStress1_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\RngchkStress1_o\\RngchkStress1_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
