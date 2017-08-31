using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__oreltailjump_cs__oreltailjump_cs_
    {
        [Fact]
        public void _Boxing_misc__oreltailjump_cs__oreltailjump_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_oreltailjump_cs\\_oreltailjump_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
