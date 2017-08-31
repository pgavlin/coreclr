using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__dbgtailjump_cs__dbgtailjump_cs_
    {
        [Fact]
        public void _Boxing_misc__dbgtailjump_cs__dbgtailjump_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_dbgtailjump_cs\\_dbgtailjump_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
