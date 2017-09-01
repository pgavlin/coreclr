using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_NullCheckAssertion3_NullCheckAssertion3_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion3_NullCheckAssertion3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion3\\NullCheckAssertion3.cmd");
        }
    }
}
