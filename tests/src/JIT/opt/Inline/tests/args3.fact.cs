using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_args3_args3_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_args3_args3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\args3\\args3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
