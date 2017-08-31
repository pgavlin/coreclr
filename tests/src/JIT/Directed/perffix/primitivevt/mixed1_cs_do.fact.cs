using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_mixed1_cs_do_mixed1_cs_do_
    {
        [Fact]
        public void _perffix_primitivevt_mixed1_cs_do_mixed1_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed1_cs_do\\mixed1_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
