using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_mixed2_cs_d_mixed2_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_mixed2_cs_d_mixed2_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed2_cs_d\\mixed2_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
