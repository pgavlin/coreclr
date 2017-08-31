using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_conv_ovf_r8_i8_conv_ovf_r8_i8_
    {
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_r8_i8_conv_ovf_r8_i8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_r8_i8\\conv_ovf_r8_i8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
