using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_simpleexpr1_1_simpleexpr1_1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_simpleexpr1_1_simpleexpr1_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\simpleexpr1_1\\simpleexpr1_1.cmd");
        }
    }
}
