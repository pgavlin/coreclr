using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_pointerexpr1_1_pointerexpr1_1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_pointerexpr1_1_pointerexpr1_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\pointerexpr1_1\\pointerexpr1_1.cmd");
        }
    }
}
