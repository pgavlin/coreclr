using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_array_array_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_array_array_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\array\\array.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
