using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_conv_ovf_conv_ovf_
    {
        [Fact]
        public void _Old_Base_conv_ovf_conv_ovf_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\conv_ovf\\conv_ovf.cmd");
        }
    }
}
