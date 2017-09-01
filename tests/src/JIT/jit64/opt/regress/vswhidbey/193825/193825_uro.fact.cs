using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_193825_193825_uro_193825_uro_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_193825_193825_uro_193825_uro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\193825\\193825_uro\\193825_uro.cmd");
        }
    }
}
