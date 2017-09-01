using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_simpleexpr4_r_try_simpleexpr4_r_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_simpleexpr4_r_try_simpleexpr4_r_try_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\simpleexpr4_r_try\\simpleexpr4_r_try.cmd");
        }
    }
}
