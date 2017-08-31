using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__dbgldfld_mul__dbgldfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_unsigned__dbgldfld_mul__dbgldfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_dbgldfld_mul\\_dbgldfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
