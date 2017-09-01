using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_Many_Inline_Many_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_Many_Inline_Many_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_Many\\Inline_Many.cmd");
        }
    }
}
