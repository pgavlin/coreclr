using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_beq_r4_beq_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_beq_r4_beq_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\beq_r4\\beq_r4.cmd");
        }
    }
}
