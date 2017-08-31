using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_throwtest_throwtest_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_throwtest_throwtest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\throwtest\\throwtest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
