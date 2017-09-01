using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_simpleexpr4_r_loop_simpleexpr4_r_loop_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_simpleexpr4_r_loop_simpleexpr4_r_loop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\simpleexpr4_r_loop\\simpleexpr4_r_loop.cmd");
        }
    }
}
