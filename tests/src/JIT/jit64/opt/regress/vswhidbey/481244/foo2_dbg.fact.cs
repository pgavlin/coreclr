using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_481244_foo2_dbg_foo2_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_481244_foo2_dbg_foo2_dbg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\481244\\foo2_dbg\\foo2_dbg.cmd");
        }
    }
}
