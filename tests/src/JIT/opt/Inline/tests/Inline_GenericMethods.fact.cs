using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_GenericMethods_Inline_GenericMethods_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_GenericMethods_Inline_GenericMethods_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_GenericMethods\\Inline_GenericMethods.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
