using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_beq_i8_beq_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_beq_i8_beq_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\beq_i8\\beq_i8.cmd");
        }
    }
}
