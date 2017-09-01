using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_arrayexpr1_arrayexpr1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_arrayexpr1_arrayexpr1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\arrayexpr1\\arrayexpr1.cmd");
        }
    }
}
