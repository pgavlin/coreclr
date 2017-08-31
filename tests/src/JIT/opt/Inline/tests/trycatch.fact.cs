using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_trycatch_trycatch_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_trycatch_trycatch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\trycatch\\trycatch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
