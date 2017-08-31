using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__speed_dbgs_ldc_div__speed_dbgs_ldc_div_
    {
        [Fact]
        public void _int64_signed__speed_dbgs_ldc_div__speed_dbgs_ldc_div_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_dbgs_ldc_div\\_speed_dbgs_ldc_div.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
