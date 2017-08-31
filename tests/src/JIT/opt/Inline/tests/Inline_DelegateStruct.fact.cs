using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_DelegateStruct_Inline_DelegateStruct_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_DelegateStruct_Inline_DelegateStruct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_DelegateStruct\\Inline_DelegateStruct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
