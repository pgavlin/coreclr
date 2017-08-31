using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_dbgexplicit8__opt_dbgexplicit8_
    {
        [Fact]
        public void _explicit_misc__opt_dbgexplicit8__opt_dbgexplicit8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_dbgexplicit8\\_opt_dbgexplicit8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
