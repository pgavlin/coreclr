using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_conv_ovf_u4_i_conv_ovf_u4_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_u4_i_conv_ovf_u4_i_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_u4_i\\conv_ovf_u4_i.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
