using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_callconv2_cs_do_callconv2_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv2_cs_do_callconv2_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv2_cs_do\\callconv2_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
