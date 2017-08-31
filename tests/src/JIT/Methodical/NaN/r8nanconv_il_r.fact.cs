using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r8nanconv_il_r_r8nanconv_il_r_
    {
        [Fact]
        public void _NaN_r8nanconv_il_r_r8nanconv_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8nanconv_il_r\\r8nanconv_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
