using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_pop_pop_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_pop_pop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\pop\\pop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
