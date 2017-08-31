using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_Conv_R4_Conv_R4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_Conv_R4_Conv_R4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\Conv_R4\\Conv_R4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
