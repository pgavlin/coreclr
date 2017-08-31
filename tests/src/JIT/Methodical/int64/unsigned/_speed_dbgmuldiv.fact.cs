using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__speed_dbgmuldiv__speed_dbgmuldiv_
    {
        [Fact]
        public void _int64_unsigned__speed_dbgmuldiv__speed_dbgmuldiv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_speed_dbgmuldiv\\_speed_dbgmuldiv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
