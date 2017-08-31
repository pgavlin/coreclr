using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch8_switch8_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch8_switch8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch8\\switch8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
