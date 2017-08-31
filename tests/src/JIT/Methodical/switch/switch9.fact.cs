using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch9_switch9_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch9_switch9_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch9\\switch9.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
