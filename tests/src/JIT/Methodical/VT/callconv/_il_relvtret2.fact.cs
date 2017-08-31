using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_relvtret2__il_relvtret2_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_relvtret2__il_relvtret2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_relvtret2\\_il_relvtret2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
