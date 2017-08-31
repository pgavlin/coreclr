using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__odbgtailjump_cs__odbgtailjump_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_misc__odbgtailjump_cs__odbgtailjump_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_odbgtailjump_cs\\_odbgtailjump_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
