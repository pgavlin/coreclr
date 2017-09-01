using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_fieldexpr2_fieldexpr2_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_fieldexpr2_fieldexpr2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\fieldexpr2\\fieldexpr2.cmd");
        }
    }
}
