using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_arrayexpr2_r_arrayexpr2_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_arrayexpr2_r_arrayexpr2_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\arrayexpr2_r\\arrayexpr2_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
