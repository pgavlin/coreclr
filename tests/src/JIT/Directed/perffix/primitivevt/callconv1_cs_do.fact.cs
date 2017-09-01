using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_callconv1_cs_do_callconv1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv1_cs_do_callconv1_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv1_cs_do\\callconv1_cs_do.cmd");
        }
    }
}
