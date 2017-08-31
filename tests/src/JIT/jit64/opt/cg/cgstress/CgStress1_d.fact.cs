using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_cgstress_CgStress1_d_CgStress1_d_
    {
        [Fact]
        public void _opt_cg_cgstress_CgStress1_d_CgStress1_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\cgstress\\CgStress1_d\\CgStress1_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
