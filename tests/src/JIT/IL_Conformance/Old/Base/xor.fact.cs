using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_xor_xor_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_xor_xor_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\xor\\xor.cmd");
        }
    }
}
