using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testC_hfa_sd2C_r_hfa_sd2C_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testC_hfa_sd2C_r_hfa_sd2C_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testC\\hfa_sd2C_r\\hfa_sd2C_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
