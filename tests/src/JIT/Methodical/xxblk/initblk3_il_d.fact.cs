using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxblk_initblk3_il_d_initblk3_il_d_
    {
        [Fact]
        public void _xxblk_initblk3_il_d_initblk3_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxblk\\initblk3_il_d\\initblk3_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
