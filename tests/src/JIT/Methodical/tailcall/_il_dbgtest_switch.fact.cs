using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgtest_switch__il_dbgtest_switch_
    {
        [Fact]
        public void _tailcall__il_dbgtest_switch__il_dbgtest_switch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgtest_switch\\_il_dbgtest_switch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
