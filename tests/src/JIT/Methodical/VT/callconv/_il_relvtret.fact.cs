using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_relvtret__il_relvtret_
    {
        [Fact]
        public void _VT_callconv__il_relvtret__il_relvtret_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_relvtret\\_il_relvtret.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
