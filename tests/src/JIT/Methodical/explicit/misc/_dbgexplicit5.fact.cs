using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__dbgexplicit5__dbgexplicit5_
    {
        [Fact]
        public void _explicit_misc__dbgexplicit5__dbgexplicit5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_dbgexplicit5\\_dbgexplicit5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
