using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_ifelse_ifelse_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_ifelse_ifelse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\ifelse\\ifelse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
