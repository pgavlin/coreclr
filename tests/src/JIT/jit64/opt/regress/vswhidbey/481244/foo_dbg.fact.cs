using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_481244_foo_dbg_foo_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_481244_foo_dbg_foo_dbg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\481244\\foo_dbg\\foo_dbg.cmd");
        }
    }
}
