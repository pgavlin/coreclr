using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testG_hfa_sf2G_r_hfa_sf2G_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testG_hfa_sf2G_r_hfa_sf2G_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testG\\hfa_sf2G_r\\hfa_sf2G_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
