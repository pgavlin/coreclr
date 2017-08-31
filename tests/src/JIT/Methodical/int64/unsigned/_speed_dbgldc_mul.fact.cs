using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__speed_dbgldc_mul__speed_dbgldc_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_unsigned__speed_dbgldc_mul__speed_dbgldc_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_speed_dbgldc_mul\\_speed_dbgldc_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
