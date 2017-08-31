using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxblk_initblk3_il_r_initblk3_il_r_
    {
        [Fact]
        public void _xxblk_initblk3_il_r_initblk3_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxblk\\initblk3_il_r\\initblk3_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
