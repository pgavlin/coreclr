using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testA_hfa_nf2A_d_hfa_nf2A_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testA_hfa_nf2A_d_hfa_nf2A_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testA\\hfa_nf2A_d\\hfa_nf2A_d.cmd");
        }
    }
}
