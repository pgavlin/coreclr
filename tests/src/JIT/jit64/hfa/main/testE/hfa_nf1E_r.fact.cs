using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testE_hfa_nf1E_r_hfa_nf1E_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testE_hfa_nf1E_r_hfa_nf1E_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testE\\hfa_nf1E_r\\hfa_nf1E_r.cmd");
        }
    }
}
