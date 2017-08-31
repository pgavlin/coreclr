using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testG_hfa_nf2G_d_hfa_nf2G_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testG_hfa_nf2G_d_hfa_nf2G_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testG\\hfa_nf2G_d\\hfa_nf2G_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
