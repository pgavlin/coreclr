using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_args1_args1_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_args1_args1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\args1\\args1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
