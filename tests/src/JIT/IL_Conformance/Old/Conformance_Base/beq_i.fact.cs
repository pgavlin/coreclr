using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_beq_i_beq_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_beq_i_beq_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\beq_i\\beq_i.cmd");
        }
    }
}
