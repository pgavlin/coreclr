using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_Recursion_Inline_Recursion_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_Recursion_Inline_Recursion_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_Recursion\\Inline_Recursion.cmd");
        }
    }
}
