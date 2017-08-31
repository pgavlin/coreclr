using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch11_switch11_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch11_switch11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch11\\switch11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
