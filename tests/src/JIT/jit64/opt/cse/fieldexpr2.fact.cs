using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_fieldexpr2_fieldexpr2_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_fieldexpr2_fieldexpr2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\fieldexpr2\\fieldexpr2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
