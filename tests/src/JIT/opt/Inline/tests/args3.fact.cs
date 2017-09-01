using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_args3_args3_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_args3_args3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\args3\\args3.cmd");
        }
    }
}
