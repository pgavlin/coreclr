using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testB_hfa_nf2B_r_hfa_nf2B_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testB_hfa_nf2B_r_hfa_nf2B_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testB\\hfa_nf2B_r\\hfa_nf2B_r.cmd");
        }
    }
}
