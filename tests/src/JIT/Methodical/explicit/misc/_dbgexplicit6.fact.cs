using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__dbgexplicit6__dbgexplicit6_
    {
        [Fact]
        public void _explicit_misc__dbgexplicit6__dbgexplicit6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_dbgexplicit6\\_dbgexplicit6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
