using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_mul_r4_mul_r4_
    {
        [Fact]
        public void _Old_Conformance_Base_mul_r4_mul_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\mul_r4\\mul_r4.cmd");
        }
    }
}
