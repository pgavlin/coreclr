using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_mixedexpr1_ro_loop_mixedexpr1_ro_loop_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_mixedexpr1_ro_loop_mixedexpr1_ro_loop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\mixedexpr1_ro_loop\\mixedexpr1_ro_loop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
