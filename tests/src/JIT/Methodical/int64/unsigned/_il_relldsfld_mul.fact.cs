using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__il_relldsfld_mul__il_relldsfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_unsigned__il_relldsfld_mul__il_relldsfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_il_relldsfld_mul\\_il_relldsfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
