using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch4_switch4_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch4_switch4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch4\\switch4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
