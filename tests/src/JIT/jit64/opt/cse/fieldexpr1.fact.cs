using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_fieldexpr1_fieldexpr1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_fieldexpr1_fieldexpr1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\fieldexpr1\\fieldexpr1.cmd");
        }
    }
}
