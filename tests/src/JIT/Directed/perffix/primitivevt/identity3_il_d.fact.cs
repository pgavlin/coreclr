using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_identity3_il_d_identity3_il_d_
    {
        [Fact]
        public void _perffix_primitivevt_identity3_il_d_identity3_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\identity3_il_d\\identity3_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
