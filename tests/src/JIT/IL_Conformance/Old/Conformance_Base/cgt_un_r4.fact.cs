using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_un_r4_cgt_un_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_un_r4_cgt_un_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_un_r4\\cgt_un_r4.cmd");
        }
    }
}
