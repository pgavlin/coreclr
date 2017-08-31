using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_cond64_il_d_cond64_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_cond64_il_d_cond64_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\cond64_il_d\\cond64_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
