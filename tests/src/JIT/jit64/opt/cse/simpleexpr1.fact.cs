using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_simpleexpr1_simpleexpr1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_simpleexpr1_simpleexpr1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\simpleexpr1\\simpleexpr1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
