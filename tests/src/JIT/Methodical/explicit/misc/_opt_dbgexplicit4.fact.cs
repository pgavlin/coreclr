using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_dbgexplicit4__opt_dbgexplicit4_
    {
        [Fact]
        public void _explicit_misc__opt_dbgexplicit4__opt_dbgexplicit4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_dbgexplicit4\\_opt_dbgexplicit4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
