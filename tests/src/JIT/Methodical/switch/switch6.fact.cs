using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch6_switch6_
    {
        [Fact]
        public void _switch_switch6_switch6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch6\\switch6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
