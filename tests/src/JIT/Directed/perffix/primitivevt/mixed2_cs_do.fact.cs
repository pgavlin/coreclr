using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_mixed2_cs_do_mixed2_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_mixed2_cs_do_mixed2_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed2_cs_do\\mixed2_cs_do.cmd");
        }
    }
}
