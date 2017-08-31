using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_RecursiveMethod_Inline_RecursiveMethod_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_RecursiveMethod_Inline_RecursiveMethod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_RecursiveMethod\\Inline_RecursiveMethod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
