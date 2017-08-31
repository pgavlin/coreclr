using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxblk_cpblk3_il_d_cpblk3_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _xxblk_cpblk3_il_d_cpblk3_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxblk\\cpblk3_il_d\\cpblk3_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
