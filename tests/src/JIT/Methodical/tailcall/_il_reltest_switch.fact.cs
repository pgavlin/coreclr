using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_reltest_switch__il_reltest_switch_
    {
        [Fact]
        public void _tailcall__il_reltest_switch__il_reltest_switch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_reltest_switch\\_il_reltest_switch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
