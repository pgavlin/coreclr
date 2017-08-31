using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_simpleexpr4_ro_loop_simpleexpr4_ro_loop_
    {
        [Fact]
        public void _opt_cse_simpleexpr4_ro_loop_simpleexpr4_ro_loop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\simpleexpr4_ro_loop\\simpleexpr4_ro_loop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
