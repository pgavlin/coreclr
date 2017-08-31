using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_NormalizeStack_Inline_NormalizeStack_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_NormalizeStack_Inline_NormalizeStack_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_NormalizeStack\\Inline_NormalizeStack.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
