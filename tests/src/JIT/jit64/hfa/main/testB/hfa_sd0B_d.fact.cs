using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testB_hfa_sd0B_d_hfa_sd0B_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testB_hfa_sd0B_d_hfa_sd0B_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testB\\hfa_sd0B_d\\hfa_sd0B_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
