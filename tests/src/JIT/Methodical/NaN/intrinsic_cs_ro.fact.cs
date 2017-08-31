using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_intrinsic_cs_ro_intrinsic_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_cs_ro_intrinsic_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_cs_ro\\intrinsic_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
