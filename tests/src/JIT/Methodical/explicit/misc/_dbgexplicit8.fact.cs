using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__dbgexplicit8__dbgexplicit8_
    {
        [Fact]
        public void _explicit_misc__dbgexplicit8__dbgexplicit8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_dbgexplicit8\\_dbgexplicit8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
