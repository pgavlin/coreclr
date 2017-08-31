using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__dbgs_ldc_mul__dbgs_ldc_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__dbgs_ldc_mul__dbgs_ldc_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_dbgs_ldc_mul\\_dbgs_ldc_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
