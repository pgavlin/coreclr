using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _hfa_main_testC_hfa_nf0C_d_hfa_nf0C_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testC_hfa_nf0C_d_hfa_nf0C_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testC\\hfa_nf0C_d\\hfa_nf0C_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
