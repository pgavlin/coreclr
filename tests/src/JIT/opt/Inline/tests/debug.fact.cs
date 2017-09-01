using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_debug_debug_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_debug_debug_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\debug\\debug.cmd");
        }
    }
}
