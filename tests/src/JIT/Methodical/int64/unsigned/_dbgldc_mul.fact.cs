using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__dbgldc_mul__dbgldc_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_unsigned__dbgldc_mul__dbgldc_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_dbgldc_mul\\_dbgldc_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
