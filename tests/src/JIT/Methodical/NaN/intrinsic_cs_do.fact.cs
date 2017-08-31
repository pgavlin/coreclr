using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_intrinsic_cs_do_intrinsic_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_cs_do_intrinsic_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_cs_do\\intrinsic_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
