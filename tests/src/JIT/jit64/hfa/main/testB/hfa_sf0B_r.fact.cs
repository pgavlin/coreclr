using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testB_hfa_sf0B_r_hfa_sf0B_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testB_hfa_sf0B_r_hfa_sf0B_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testB\\hfa_sf0B_r\\hfa_sf0B_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
