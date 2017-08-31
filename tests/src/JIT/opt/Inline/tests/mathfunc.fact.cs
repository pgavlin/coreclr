using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_mathfunc_mathfunc_
    {
        [Fact]
        public void _Inline_tests_mathfunc_mathfunc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\mathfunc\\mathfunc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
