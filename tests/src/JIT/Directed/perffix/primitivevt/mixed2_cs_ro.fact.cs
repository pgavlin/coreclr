using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _perffix_primitivevt_mixed2_cs_ro_mixed2_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_mixed2_cs_ro_mixed2_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed2_cs_ro\\mixed2_cs_ro.cmd");
        }
    }
}
