using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_beq_beq_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_beq_beq_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\beq\\beq.cmd");
        }
    }
}
