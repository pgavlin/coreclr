using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_intrinsic_cs_r_intrinsic_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_cs_r_intrinsic_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_cs_r\\intrinsic_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
