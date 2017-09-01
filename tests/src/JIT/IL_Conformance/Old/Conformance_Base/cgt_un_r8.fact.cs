using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_un_r8_cgt_un_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_un_r8_cgt_un_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_un_r8\\cgt_un_r8.cmd");
        }
    }
}
