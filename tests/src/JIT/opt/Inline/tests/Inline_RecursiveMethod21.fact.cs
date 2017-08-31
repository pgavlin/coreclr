using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_RecursiveMethod21_Inline_RecursiveMethod21_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_RecursiveMethod21_Inline_RecursiveMethod21_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_RecursiveMethod21\\Inline_RecursiveMethod21.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
