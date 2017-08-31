using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_dbgaddress__il_dbgaddress_
    {
        [Fact]
        public void _Arrays_misc__il_dbgaddress__il_dbgaddress_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_dbgaddress\\_il_dbgaddress.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
