using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_arithm32_r_arithm32_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_r_arithm32_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_r\\arithm32_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
