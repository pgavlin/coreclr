using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_mul_ovf_i4_ldc_mul_ovf_i4_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_mul_ovf_i4_ldc_mul_ovf_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_mul_ovf_i4\\ldc_mul_ovf_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
