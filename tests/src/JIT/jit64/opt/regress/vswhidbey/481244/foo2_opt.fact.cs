using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_481244_foo2_opt_foo2_opt_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_481244_foo2_opt_foo2_opt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\481244\\foo2_opt\\foo2_opt.cmd");
        }
    }
}
