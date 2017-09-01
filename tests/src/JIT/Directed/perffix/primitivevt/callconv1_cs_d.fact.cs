using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_callconv1_cs_d_callconv1_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv1_cs_d_callconv1_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv1_cs_d\\callconv1_cs_d.cmd");
        }
    }
}
