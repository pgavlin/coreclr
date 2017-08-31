using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_comp64_il_r_comp64_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_comp64_il_r_comp64_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\comp64_il_r\\comp64_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
