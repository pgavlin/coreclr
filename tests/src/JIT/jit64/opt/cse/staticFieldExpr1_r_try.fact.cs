using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_staticFieldExpr1_r_try_staticFieldExpr1_r_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_staticFieldExpr1_r_try_staticFieldExpr1_r_try_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExpr1_r_try\\staticFieldExpr1_r_try.cmd");
        }
    }
}
