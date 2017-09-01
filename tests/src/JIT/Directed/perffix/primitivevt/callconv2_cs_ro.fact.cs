using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_callconv2_cs_ro_callconv2_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv2_cs_ro_callconv2_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv2_cs_ro\\callconv2_cs_ro.cmd");
        }
    }
}
