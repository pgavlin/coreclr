using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch1_switch1_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch1_switch1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch1\\switch1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
