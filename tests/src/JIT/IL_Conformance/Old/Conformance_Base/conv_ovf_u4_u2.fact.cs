using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_conv_ovf_u4_u2_conv_ovf_u4_u2_
    {
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_u4_u2_conv_ovf_u4_u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_u4_u2\\conv_ovf_u4_u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
