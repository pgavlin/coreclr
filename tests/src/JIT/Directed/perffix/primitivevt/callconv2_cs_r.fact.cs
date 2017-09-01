using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_callconv2_cs_r_callconv2_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_callconv2_cs_r_callconv2_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\callconv2_cs_r\\callconv2_cs_r.cmd");
        }
    }
}
