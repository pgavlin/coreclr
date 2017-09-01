using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_handler_Inline_handler_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_handler_Inline_handler_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_handler\\Inline_handler.cmd");
        }
    }
}
