using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_dbgexplicit7__opt_dbgexplicit7_
    {
        [Fact]
        public void _explicit_misc__opt_dbgexplicit7__opt_dbgexplicit7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_dbgexplicit7\\_opt_dbgexplicit7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
