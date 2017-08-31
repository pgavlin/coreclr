using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r8NaNmul_cs_d_r8NaNmul_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNmul_cs_d_r8NaNmul_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNmul_cs_d\\r8NaNmul_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
