using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_conv_ovf_r8_i_ldc_conv_ovf_r8_i_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_conv_ovf_r8_i_ldc_conv_ovf_r8_i_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_conv_ovf_r8_i\\ldc_conv_ovf_r8_i.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
