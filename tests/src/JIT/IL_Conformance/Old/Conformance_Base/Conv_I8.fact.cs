using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_Conv_I8_Conv_I8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_Conv_I8_Conv_I8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\Conv_I8\\Conv_I8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
