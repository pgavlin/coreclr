using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_cgstress_CgStress2_do_CgStress2_do_
    {
        [Fact]
        public void _opt_cg_cgstress_CgStress2_do_CgStress2_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\cgstress\\CgStress2_do\\CgStress2_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
