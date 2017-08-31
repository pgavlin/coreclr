using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_NullCheckAssertion5_NullCheckAssertion5_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion5_NullCheckAssertion5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion5\\NullCheckAssertion5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
