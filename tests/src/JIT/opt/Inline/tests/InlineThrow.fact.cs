using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_InlineThrow_InlineThrow_
    {
        [Fact]
        public void _Inline_tests_InlineThrow_InlineThrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\InlineThrow\\InlineThrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
