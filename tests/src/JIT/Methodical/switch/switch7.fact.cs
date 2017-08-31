using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch7_switch7_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch7_switch7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch7\\switch7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
