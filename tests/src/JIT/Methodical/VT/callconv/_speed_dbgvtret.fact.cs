using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__speed_dbgvtret__speed_dbgvtret_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__speed_dbgvtret__speed_dbgvtret_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_dbgvtret\\_speed_dbgvtret.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
