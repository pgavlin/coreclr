using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_228572_conv_dbg_conv_dbg_
    {
        [Fact]
        public void _opt_regress_vswhidbey_228572_conv_dbg_conv_dbg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\228572\\conv_dbg\\conv_dbg.cmd");
        }
    }
}
