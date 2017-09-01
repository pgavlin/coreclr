using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bge_un_r8_bge_un_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bge_un_r8_bge_un_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bge_un_r8\\bge_un_r8.cmd");
        }
    }
}
