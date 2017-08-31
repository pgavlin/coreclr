using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_NewObj_Inline_NewObj_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_NewObj_Inline_NewObj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_NewObj\\Inline_NewObj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
