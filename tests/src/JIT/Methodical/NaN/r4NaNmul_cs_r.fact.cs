using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r4NaNmul_cs_r_r4NaNmul_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNmul_cs_r_r4NaNmul_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNmul_cs_r\\r4NaNmul_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
