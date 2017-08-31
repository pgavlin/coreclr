using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testB_hfa_nd2B_d_hfa_nd2B_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testB_hfa_nd2B_d_hfa_nd2B_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testB\\hfa_nd2B_d\\hfa_nd2B_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
