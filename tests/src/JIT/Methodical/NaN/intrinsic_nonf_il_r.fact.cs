using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_intrinsic_nonf_il_r_intrinsic_nonf_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_nonf_il_r_intrinsic_nonf_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_nonf_il_r\\intrinsic_nonf_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
