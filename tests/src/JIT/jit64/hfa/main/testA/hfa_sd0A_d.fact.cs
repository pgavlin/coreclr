using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testA_hfa_sd0A_d_hfa_sd0A_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testA_hfa_sd0A_d_hfa_sd0A_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testA\\hfa_sd0A_d\\hfa_sd0A_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
