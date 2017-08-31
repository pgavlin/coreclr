using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_STARG_Inline_STARG_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_STARG_Inline_STARG_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_STARG\\Inline_STARG.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
