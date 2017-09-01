using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_mul_r8_mul_r8_
    {
        [Fact]
        public void _Old_Conformance_Base_mul_r8_mul_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\mul_r8\\mul_r8.cmd");
        }
    }
}
