using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_NullCheckAssertion1_NullCheckAssertion1_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_NullCheckAssertion1_NullCheckAssertion1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\NullCheckAssertion1\\NullCheckAssertion1.cmd");
        }
    }
}
