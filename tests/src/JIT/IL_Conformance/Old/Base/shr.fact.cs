using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_shr_shr_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_shr_shr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\shr\\shr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
