using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_ArrayOfStructs_ArrayOfStructs_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_ArrayOfStructs_ArrayOfStructs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\ArrayOfStructs\\ArrayOfStructs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
