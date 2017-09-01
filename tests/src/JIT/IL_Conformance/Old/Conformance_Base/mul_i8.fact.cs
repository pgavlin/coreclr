using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_mul_i8_mul_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_mul_i8_mul_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\mul_i8\\mul_i8.cmd");
        }
    }
}
