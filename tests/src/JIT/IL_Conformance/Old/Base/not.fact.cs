using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_not_not_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_not_not_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\not\\not.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
