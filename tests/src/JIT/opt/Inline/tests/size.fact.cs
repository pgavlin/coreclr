using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_size_size_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_size_size_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\size\\size.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
