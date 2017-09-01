using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_callconv1_cs_ro_callconv1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv1_cs_ro_callconv1_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv1_cs_ro\\callconv1_cs_ro.cmd");
        }
    }
}
