using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_conv_ovf_i1_un_conv_ovf_i1_un_
    {
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_i1_un_conv_ovf_i1_un_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_i1_un\\conv_ovf_i1_un.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
