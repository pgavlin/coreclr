using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_phoenix_62322_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _regress_phoenix_62322_test_test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\phoenix\\62322\\test\\test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
