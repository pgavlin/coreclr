using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_dbgexplicit3__opt_dbgexplicit3_
    {
        [Fact]
        public void _explicit_misc__opt_dbgexplicit3__opt_dbgexplicit3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_dbgexplicit3\\_opt_dbgexplicit3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
