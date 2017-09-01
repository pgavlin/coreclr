using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_args1_args1_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_args1_args1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\args1\\args1.cmd");
        }
    }
}
