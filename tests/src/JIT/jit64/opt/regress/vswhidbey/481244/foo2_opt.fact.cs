using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_regress_vswhidbey_481244_foo2_opt_foo2_opt_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_481244_foo2_opt_foo2_opt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\481244\\foo2_opt\\foo2_opt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
