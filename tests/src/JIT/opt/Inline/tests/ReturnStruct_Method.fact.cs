using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_ReturnStruct_Method_ReturnStruct_Method_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_ReturnStruct_Method_ReturnStruct_Method_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\ReturnStruct_Method\\ReturnStruct_Method.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
