using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgvtret__il_dbgvtret_
    {
        [Fact]
        public void _VT_callconv__il_dbgvtret__il_dbgvtret_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgvtret\\_il_dbgvtret.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
