using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_dbgexplicit6__opt_dbgexplicit6_
    {
        [Fact]
        public void _explicit_misc__opt_dbgexplicit6__opt_dbgexplicit6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_dbgexplicit6\\_opt_dbgexplicit6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
