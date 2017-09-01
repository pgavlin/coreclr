using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_xor_u4_xor_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_xor_u4_xor_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\xor_u4\\xor_u4.cmd");
        }
    }
}
