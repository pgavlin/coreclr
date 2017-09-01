using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_sub_ovf_i4_ldc_sub_ovf_i4_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_sub_ovf_i4_ldc_sub_ovf_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_sub_ovf_i4\\ldc_sub_ovf_i4.cmd");
        }
    }
}
