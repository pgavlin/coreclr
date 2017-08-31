using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_373472_test_il_test_il_
    {
        [Fact]
        public void _regress_vsw_373472_test_il_test_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\373472\\test_il\\test_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
