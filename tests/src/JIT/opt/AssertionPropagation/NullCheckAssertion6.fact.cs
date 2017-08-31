using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_NullCheckAssertion6_NullCheckAssertion6_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion6_NullCheckAssertion6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion6\\NullCheckAssertion6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
