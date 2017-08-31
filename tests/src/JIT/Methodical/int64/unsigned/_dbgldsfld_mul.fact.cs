using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__dbgldsfld_mul__dbgldsfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_unsigned__dbgldsfld_mul__dbgldsfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_dbgldsfld_mul\\_dbgldsfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
