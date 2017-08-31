using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_NullCheckAssertion1_NullCheckAssertion1_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion1_NullCheckAssertion1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion1\\NullCheckAssertion1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
