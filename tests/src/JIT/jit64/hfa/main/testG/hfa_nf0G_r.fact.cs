using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testG_hfa_nf0G_r_hfa_nf0G_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testG_hfa_nf0G_r_hfa_nf0G_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testG\\hfa_nf0G_r\\hfa_nf0G_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
