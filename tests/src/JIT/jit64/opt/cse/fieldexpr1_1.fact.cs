using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_fieldexpr1_1_fieldexpr1_1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_fieldexpr1_1_fieldexpr1_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\fieldexpr1_1\\fieldexpr1_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
