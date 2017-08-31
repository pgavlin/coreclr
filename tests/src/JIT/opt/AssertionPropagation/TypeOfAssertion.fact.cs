using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_TypeOfAssertion_TypeOfAssertion_
    {
        [OuterLoop]
        [Fact]
        public void _AssertionPropagation_TypeOfAssertion_TypeOfAssertion_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\TypeOfAssertion\\TypeOfAssertion.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
