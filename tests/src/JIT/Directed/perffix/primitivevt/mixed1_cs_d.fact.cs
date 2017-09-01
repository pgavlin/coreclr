using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_mixed1_cs_d_mixed1_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_mixed1_cs_d_mixed1_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed1_cs_d\\mixed1_cs_d.cmd");
        }
    }
}
