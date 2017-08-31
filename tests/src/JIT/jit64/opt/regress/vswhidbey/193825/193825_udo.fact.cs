using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_regress_vswhidbey_193825_193825_udo_193825_udo_
    {
        [OuterLoop]
        [Fact]
        public void _opt_regress_vswhidbey_193825_193825_udo_193825_udo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\193825\\193825_udo\\193825_udo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
