using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_Many_Inline_Many_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_Many_Inline_Many_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_Many\\Inline_Many.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
