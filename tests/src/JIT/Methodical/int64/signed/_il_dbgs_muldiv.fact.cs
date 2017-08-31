using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__il_dbgs_muldiv__il_dbgs_muldiv_
    {
        [Fact]
        public void _int64_signed__il_dbgs_muldiv__il_dbgs_muldiv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_il_dbgs_muldiv\\_il_dbgs_muldiv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
