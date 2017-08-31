using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_debug_debug_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_debug_debug_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\debug\\debug.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
