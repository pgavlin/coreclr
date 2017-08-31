using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_NullCheckAssertion3_NullCheckAssertion3_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion3_NullCheckAssertion3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion3\\NullCheckAssertion3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
