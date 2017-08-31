using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_regress_vswhidbey_481244_foo_dbg_foo_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_481244_foo_dbg_foo_dbg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\481244\\foo_dbg\\foo_dbg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
