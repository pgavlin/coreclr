using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testG_hfa_nf1G_r_hfa_nf1G_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testG_hfa_nf1G_r_hfa_nf1G_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testG\\hfa_nf1G_r\\hfa_nf1G_r.cmd");
        }
    }
}
