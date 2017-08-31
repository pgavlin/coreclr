using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__dbgs_ldfld_mul__dbgs_ldfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__dbgs_ldfld_mul__dbgs_ldfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_dbgs_ldfld_mul\\_dbgs_ldfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
