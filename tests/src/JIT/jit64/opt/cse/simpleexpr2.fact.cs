using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_simpleexpr2_simpleexpr2_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_simpleexpr2_simpleexpr2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\simpleexpr2\\simpleexpr2.cmd");
        }
    }
}
