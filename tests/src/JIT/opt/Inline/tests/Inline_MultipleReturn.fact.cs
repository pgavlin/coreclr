using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_MultipleReturn_Inline_MultipleReturn_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_MultipleReturn_Inline_MultipleReturn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_MultipleReturn\\Inline_MultipleReturn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
