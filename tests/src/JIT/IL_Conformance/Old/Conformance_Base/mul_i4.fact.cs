using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_mul_i4_mul_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_mul_i4_mul_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\mul_i4\\mul_i4.cmd");
        }
    }
}
