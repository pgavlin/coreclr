using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_mixedexpr1_r_mixedexpr1_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_mixedexpr1_r_mixedexpr1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\mixedexpr1_r\\mixedexpr1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
