using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_mthdimpl_mthdimpl_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_mthdimpl_mthdimpl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\mthdimpl\\mthdimpl.cmd");
        }
    }
}
