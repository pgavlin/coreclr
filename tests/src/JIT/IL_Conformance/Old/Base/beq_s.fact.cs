using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_beq_s_beq_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_beq_s_beq_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\beq_s\\beq_s.cmd");
        }
    }
}
