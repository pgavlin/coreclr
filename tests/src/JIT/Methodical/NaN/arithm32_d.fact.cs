using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_arithm32_d_arithm32_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_d_arithm32_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_d\\arithm32_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
