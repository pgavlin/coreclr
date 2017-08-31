using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__dbgexplicit7__dbgexplicit7_
    {
        [Fact]
        public void _explicit_misc__dbgexplicit7__dbgexplicit7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_dbgexplicit7\\_dbgexplicit7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
