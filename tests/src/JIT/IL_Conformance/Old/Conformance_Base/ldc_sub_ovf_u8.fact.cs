using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_sub_ovf_u8_ldc_sub_ovf_u8_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_sub_ovf_u8_ldc_sub_ovf_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_sub_ovf_u8\\ldc_sub_ovf_u8.cmd");
        }
    }
}
