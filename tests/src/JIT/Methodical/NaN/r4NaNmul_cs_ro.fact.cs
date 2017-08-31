using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r4NaNmul_cs_ro_r4NaNmul_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNmul_cs_ro_r4NaNmul_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNmul_cs_ro\\r4NaNmul_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
