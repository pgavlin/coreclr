using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_InlineThrow_InlineThrow_
    {
        [Fact]
        public void _Inline_tests_InlineThrow_InlineThrow_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\InlineThrow\\InlineThrow.cmd");
        }
    }
}
