using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_intrinsic_nonf_il_d_intrinsic_nonf_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_nonf_il_d_intrinsic_nonf_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_nonf_il_d\\intrinsic_nonf_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
