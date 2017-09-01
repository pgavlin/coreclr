using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_trycatch_trycatch_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_trycatch_trycatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\trycatch\\trycatch.cmd");
        }
    }
}
