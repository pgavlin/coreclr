using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_mul_i8_mul_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_mul_i8_mul_i8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\mul_i8\\mul_i8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
