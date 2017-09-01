using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_NullCheckAssertion2_NullCheckAssertion2_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion2_NullCheckAssertion2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion2\\NullCheckAssertion2.cmd");
        }
    }
}
