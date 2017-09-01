using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_conv_ovf_i4_u4_ldc_conv_ovf_i4_u4_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_conv_ovf_i4_u4_ldc_conv_ovf_i4_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_conv_ovf_i4_u4\\ldc_conv_ovf_i4_u4.cmd");
        }
    }
}
