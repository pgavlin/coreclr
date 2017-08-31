using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__speed_relldfld_mul__speed_relldfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_unsigned__speed_relldfld_mul__speed_relldfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_speed_relldfld_mul\\_speed_relldfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
