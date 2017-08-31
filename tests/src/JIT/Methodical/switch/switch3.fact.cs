using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch3_switch3_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch3_switch3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch3\\switch3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
