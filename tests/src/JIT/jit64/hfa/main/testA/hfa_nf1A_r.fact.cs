using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testA_hfa_nf1A_r_hfa_nf1A_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testA_hfa_nf1A_r_hfa_nf1A_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testA\\hfa_nf1A_r\\hfa_nf1A_r.cmd");
        }
    }
}
