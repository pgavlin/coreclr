using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_conv_ovf_i4_u4_conv_ovf_i4_u4_
    {
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_i4_u4_conv_ovf_i4_u4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_i4_u4\\conv_ovf_i4_u4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
