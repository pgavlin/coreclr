using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_conv_ovf_u4_u1_ldc_conv_ovf_u4_u1_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_conv_ovf_u4_u1_ldc_conv_ovf_u4_u1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_conv_ovf_u4_u1\\ldc_conv_ovf_u4_u1.cmd");
        }
    }
}
