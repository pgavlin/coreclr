using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_rngchk_RngchkStress3_RngchkStress3_
    {
        [Fact]
        public void _opt_rngchk_RngchkStress3_RngchkStress3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\rngchk\\RngchkStress3\\RngchkStress3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
