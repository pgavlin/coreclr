using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _perffix_primitivevt_mixed2_cs_r_mixed2_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _perffix_primitivevt_mixed2_cs_r_mixed2_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\perffix\\primitivevt\\mixed2_cs_r\\mixed2_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
