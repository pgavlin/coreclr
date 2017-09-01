using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_add_ovf_u4_ldc_add_ovf_u4_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_add_ovf_u4_ldc_add_ovf_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_add_ovf_u4\\ldc_add_ovf_u4.cmd");
        }
    }
}
