using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__il_dbgmuldiv__il_dbgmuldiv_
    {
        [Fact]
        public void _int64_unsigned__il_dbgmuldiv__il_dbgmuldiv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_il_dbgmuldiv\\_il_dbgmuldiv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
