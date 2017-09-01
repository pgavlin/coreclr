using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_args2_args2_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_args2_args2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\args2\\args2.cmd");
        }
    }
}
