using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_cond32_il_r_cond32_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_cond32_il_r_cond32_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\cond32_il_r\\cond32_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
