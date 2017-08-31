using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_callconv3_il_r_callconv3_il_r_
    {
        [Fact]
        public void _perffix_primitivevt_callconv3_il_r_callconv3_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv3_il_r\\callconv3_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
