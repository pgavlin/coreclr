using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bge_r8_bge_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bge_r8_bge_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bge_r8\\bge_r8.cmd");
        }
    }
}
