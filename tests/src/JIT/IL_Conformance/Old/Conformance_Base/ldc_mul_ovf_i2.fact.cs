using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_mul_ovf_i2_ldc_mul_ovf_i2_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_mul_ovf_i2_ldc_mul_ovf_i2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_mul_ovf_i2\\ldc_mul_ovf_i2.cmd");
        }
    }
}
