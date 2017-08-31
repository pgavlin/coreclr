using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_interfaceCall_interfaceCall_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_interfaceCall_interfaceCall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\interfaceCall\\interfaceCall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
