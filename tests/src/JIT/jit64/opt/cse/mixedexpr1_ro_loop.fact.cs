using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_mixedexpr1_ro_loop_mixedexpr1_ro_loop_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_mixedexpr1_ro_loop_mixedexpr1_ro_loop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\mixedexpr1_ro_loop\\mixedexpr1_ro_loop.cmd");
        }
    }
}
