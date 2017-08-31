using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_conv_ovf_u4_u2_ldc_conv_ovf_u4_u2_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_conv_ovf_u4_u2_ldc_conv_ovf_u4_u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_conv_ovf_u4_u2\\ldc_conv_ovf_u4_u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
