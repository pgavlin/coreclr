using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_comp32_il_d_comp32_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_comp32_il_d_comp32_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\comp32_il_d\\comp32_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
