using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_add_ovf_i8_add_ovf_i8_
    {
        [Fact]
        public void _Old_Conformance_Base_add_ovf_i8_add_ovf_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\add_ovf_i8\\add_ovf_i8.cmd");
        }
    }
}
