using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_throwtest_throwtest_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_throwtest_throwtest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\throwtest\\throwtest.cmd");
        }
    }
}
