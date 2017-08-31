using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_NullCheckAssertion2_NullCheckAssertion2_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion2_NullCheckAssertion2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion2\\NullCheckAssertion2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
