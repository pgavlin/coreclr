using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_arithm32_cs_do_arithm32_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_cs_do_arithm32_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_cs_do\\arithm32_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
