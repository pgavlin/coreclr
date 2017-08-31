using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_callconv2_cs_d_callconv2_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv2_cs_d_callconv2_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv2_cs_d\\callconv2_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
