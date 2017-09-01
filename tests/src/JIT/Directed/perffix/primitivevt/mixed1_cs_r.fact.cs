using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_mixed1_cs_r_mixed1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_mixed1_cs_r_mixed1_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed1_cs_r\\mixed1_cs_r.cmd");
        }
    }
}
