using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_conv_ovf_i8_i4_conv_ovf_i8_i4_
    {
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_i8_i4_conv_ovf_i8_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_i8_i4\\conv_ovf_i8_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
