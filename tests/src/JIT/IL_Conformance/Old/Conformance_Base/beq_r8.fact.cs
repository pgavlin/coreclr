using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_beq_r8_beq_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_beq_r8_beq_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\beq_r8\\beq_r8.cmd");
        }
    }
}
