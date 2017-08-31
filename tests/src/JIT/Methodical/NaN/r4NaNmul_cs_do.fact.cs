using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r4NaNmul_cs_do_r4NaNmul_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNmul_cs_do_r4NaNmul_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNmul_cs_do\\r4NaNmul_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
