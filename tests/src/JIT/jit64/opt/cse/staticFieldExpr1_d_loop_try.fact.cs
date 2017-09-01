using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_staticFieldExpr1_d_loop_try_staticFieldExpr1_d_loop_try_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_staticFieldExpr1_d_loop_try_staticFieldExpr1_d_loop_try_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\staticFieldExpr1_d_loop_try\\staticFieldExpr1_d_loop_try.cmd");
        }
    }
}
