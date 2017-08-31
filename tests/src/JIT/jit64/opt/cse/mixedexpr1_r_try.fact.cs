using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_mixedexpr1_r_try_mixedexpr1_r_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_mixedexpr1_r_try_mixedexpr1_r_try_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\mixedexpr1_r_try\\mixedexpr1_r_try.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
