using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch10_switch10_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch10_switch10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch10\\switch10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
