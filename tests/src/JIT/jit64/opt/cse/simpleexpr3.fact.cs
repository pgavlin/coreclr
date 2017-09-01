using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_simpleexpr3_simpleexpr3_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_simpleexpr3_simpleexpr3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\simpleexpr3\\simpleexpr3.cmd");
        }
    }
}
