using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_add_ovf_u8_add_ovf_u8_
    {
        [Fact]
        public void _Old_Conformance_Base_add_ovf_u8_add_ovf_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\add_ovf_u8\\add_ovf_u8.cmd");
        }
    }
}
