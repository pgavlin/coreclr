using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_mixed1_cs_ro_mixed1_cs_ro_
    {
        [Fact]
        public void _perffix_primitivevt_mixed1_cs_ro_mixed1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed1_cs_ro\\mixed1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
