using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_mul_ovf_i8_mul_ovf_i8_
    {
        [Fact]
        public void _Old_Conformance_Base_mul_ovf_i8_mul_ovf_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\mul_ovf_i8\\mul_ovf_i8.cmd");
        }
    }
}
