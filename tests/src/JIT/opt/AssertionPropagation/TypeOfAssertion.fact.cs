using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_TypeOfAssertion_TypeOfAssertion_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_TypeOfAssertion_TypeOfAssertion_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\TypeOfAssertion\\TypeOfAssertion.cmd");
        }
    }
}
