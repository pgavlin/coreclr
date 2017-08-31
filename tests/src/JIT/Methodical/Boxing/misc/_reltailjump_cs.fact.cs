using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__reltailjump_cs__reltailjump_cs_
    {
        [Fact]
        public void _Boxing_misc__reltailjump_cs__reltailjump_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_reltailjump_cs\\_reltailjump_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
