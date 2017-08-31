using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__dbgexplicit1__dbgexplicit1_
    {
        [Fact]
        public void _explicit_misc__dbgexplicit1__dbgexplicit1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_dbgexplicit1\\_dbgexplicit1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
