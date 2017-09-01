using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_un_r8_bgt_un_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_un_r8_bgt_un_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_un_r8\\bgt_un_r8.cmd");
        }
    }
}
