using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r4NaNadd_cs_d_r4NaNadd_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNadd_cs_d_r4NaNadd_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNadd_cs_d\\r4NaNadd_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
