using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_NormalizeStack_Inline_NormalizeStack_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_NormalizeStack_Inline_NormalizeStack_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_NormalizeStack\\Inline_NormalizeStack.cmd");
        }
    }
}
