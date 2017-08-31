using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_deepcall_deepcall_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_deepcall_deepcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\deepcall\\deepcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
