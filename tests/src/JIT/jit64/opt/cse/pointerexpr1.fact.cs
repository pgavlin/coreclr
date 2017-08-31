using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_pointerexpr1_pointerexpr1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_pointerexpr1_pointerexpr1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\pointerexpr1\\pointerexpr1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
