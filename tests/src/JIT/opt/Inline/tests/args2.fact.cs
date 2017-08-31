using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_args2_args2_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_args2_args2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\args2\\args2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
