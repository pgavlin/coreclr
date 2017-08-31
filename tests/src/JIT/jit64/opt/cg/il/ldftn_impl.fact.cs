using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cg_il_ldftn_impl_ldftn_impl_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cg_il_ldftn_impl_ldftn_impl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cg\\il\\ldftn_impl\\ldftn_impl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
