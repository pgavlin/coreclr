using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_cgstress_CgStress1_ro_CgStress1_ro_
    {
        [Fact]
        public void _opt_cg_cgstress_CgStress1_ro_CgStress1_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\cgstress\\CgStress1_ro\\CgStress1_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
