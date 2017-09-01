using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_mixedexpr1_r_mixedexpr1_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_mixedexpr1_r_mixedexpr1_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\mixedexpr1_r\\mixedexpr1_r.cmd");
        }
    }
}
