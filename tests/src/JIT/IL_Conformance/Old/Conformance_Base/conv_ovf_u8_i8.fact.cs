using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_conv_ovf_u8_i8_conv_ovf_u8_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_conv_ovf_u8_i8_conv_ovf_u8_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\conv_ovf_u8_i8\\conv_ovf_u8_i8.cmd");
        }
    }
}
