using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testE_hfa_sf2E_d_hfa_sf2E_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testE_hfa_sf2E_d_hfa_sf2E_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testE\\hfa_sf2E_d\\hfa_sf2E_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
