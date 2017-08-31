using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testE_hfa_sd1E_r_hfa_sd1E_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testE_hfa_sd1E_r_hfa_sd1E_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testE\\hfa_sd1E_r\\hfa_sd1E_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
