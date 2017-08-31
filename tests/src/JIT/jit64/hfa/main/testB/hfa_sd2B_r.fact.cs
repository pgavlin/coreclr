using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testB_hfa_sd2B_r_hfa_sd2B_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testB_hfa_sd2B_r_hfa_sd2B_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testB\\hfa_sd2B_r\\hfa_sd2B_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
