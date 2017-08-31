using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_cgstress_CgStress2_ro_CgStress2_ro_
    {
        [Fact]
        public void _opt_cg_cgstress_CgStress2_ro_CgStress2_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\cgstress\\CgStress2_ro\\CgStress2_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
