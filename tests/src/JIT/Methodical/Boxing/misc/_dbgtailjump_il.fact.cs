using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__dbgtailjump_il__dbgtailjump_il_
    {
        [Fact]
        public void _Boxing_misc__dbgtailjump_il__dbgtailjump_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_dbgtailjump_il\\_dbgtailjump_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
