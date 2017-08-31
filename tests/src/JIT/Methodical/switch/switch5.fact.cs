using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _switch_switch5_switch5_
    {
        [Fact]
        public void _switch_switch5_switch5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch5\\switch5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
