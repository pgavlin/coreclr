using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_conv_ovf_u4_u1_conv_ovf_u4_u1_
    {
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_u4_u1_conv_ovf_u4_u1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_u4_u1\\conv_ovf_u4_u1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
