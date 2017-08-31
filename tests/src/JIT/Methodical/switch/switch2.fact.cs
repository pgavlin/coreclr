using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch2_switch2_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch2_switch2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch2\\switch2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
