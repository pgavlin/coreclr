using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__il_dbglivecall__il_dbglivecall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__il_dbglivecall__il_dbglivecall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_il_dbglivecall\\_il_dbglivecall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
