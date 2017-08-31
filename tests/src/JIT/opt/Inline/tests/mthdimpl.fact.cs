using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_mthdimpl_mthdimpl_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_mthdimpl_mthdimpl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\mthdimpl\\mthdimpl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
