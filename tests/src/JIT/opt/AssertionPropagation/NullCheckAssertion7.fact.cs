using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_NullCheckAssertion7_NullCheckAssertion7_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion7_NullCheckAssertion7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion7\\NullCheckAssertion7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
