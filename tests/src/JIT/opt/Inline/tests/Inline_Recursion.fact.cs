using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_Recursion_Inline_Recursion_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_Recursion_Inline_Recursion_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_Recursion\\Inline_Recursion.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
