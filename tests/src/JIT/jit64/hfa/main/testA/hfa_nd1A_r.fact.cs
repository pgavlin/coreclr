using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testA_hfa_nd1A_r_hfa_nd1A_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testA_hfa_nd1A_r_hfa_nd1A_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testA\\hfa_nd1A_r\\hfa_nd1A_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
