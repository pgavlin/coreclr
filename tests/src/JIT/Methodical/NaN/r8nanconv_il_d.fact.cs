using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r8nanconv_il_d_r8nanconv_il_d_
    {
        [Fact]
        public void _NaN_r8nanconv_il_d_r8nanconv_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8nanconv_il_d\\r8nanconv_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
