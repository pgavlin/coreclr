using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__speed_dbgs_ldfld_mul__speed_dbgs_ldfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__speed_dbgs_ldfld_mul__speed_dbgs_ldfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_dbgs_ldfld_mul\\_speed_dbgs_ldfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
