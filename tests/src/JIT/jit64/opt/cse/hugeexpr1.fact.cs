using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_hugeexpr1_hugeexpr1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_hugeexpr1_hugeexpr1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\hugeexpr1\\hugeexpr1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
