using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_cond32_il_d_cond32_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_cond32_il_d_cond32_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\cond32_il_d\\cond32_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
