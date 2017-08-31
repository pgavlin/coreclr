using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_NullCheckAssertion4_NullCheckAssertion4_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion4_NullCheckAssertion4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion4\\NullCheckAssertion4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
