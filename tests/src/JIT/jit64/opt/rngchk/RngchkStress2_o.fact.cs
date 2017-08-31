using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_RngchkStress2_o_RngchkStress2_o_
    {
        [Fact]
        public void _opt_rngchk_RngchkStress2_o_RngchkStress2_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\RngchkStress2_o\\RngchkStress2_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
