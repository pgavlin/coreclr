using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_Inline_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_Inline_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline\\Inline.cmd");
        }
    }
}
