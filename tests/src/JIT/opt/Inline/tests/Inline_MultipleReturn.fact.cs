using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_MultipleReturn_Inline_MultipleReturn_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_MultipleReturn_Inline_MultipleReturn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_MultipleReturn\\Inline_MultipleReturn.cmd");
        }
    }
}
