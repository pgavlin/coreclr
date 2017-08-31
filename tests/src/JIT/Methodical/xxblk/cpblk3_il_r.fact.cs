using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxblk_cpblk3_il_r_cpblk3_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _xxblk_cpblk3_il_r_cpblk3_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxblk\\cpblk3_il_r\\cpblk3_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
