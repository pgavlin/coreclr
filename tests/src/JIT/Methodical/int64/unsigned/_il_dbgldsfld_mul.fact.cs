using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__il_dbgldsfld_mul__il_dbgldsfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_unsigned__il_dbgldsfld_mul__il_dbgldsfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_il_dbgldsfld_mul\\_il_dbgldsfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
