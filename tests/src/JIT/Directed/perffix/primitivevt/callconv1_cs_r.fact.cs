using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_callconv1_cs_r_callconv1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv1_cs_r_callconv1_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv1_cs_r\\callconv1_cs_r.cmd");
        }
    }
}
