using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_mul_ovf_u2_mul_ovf_u2_
    {
        [Fact]
        public void _Old_Conformance_Base_mul_ovf_u2_mul_ovf_u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\mul_ovf_u2\\mul_ovf_u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
