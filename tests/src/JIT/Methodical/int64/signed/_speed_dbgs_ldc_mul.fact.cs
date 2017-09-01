using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _int64_signed__speed_dbgs_ldc_mul__speed_dbgs_ldc_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__speed_dbgs_ldc_mul__speed_dbgs_ldc_mul_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_dbgs_ldc_mul\\_speed_dbgs_ldc_mul.cmd");
        }
    }
}
