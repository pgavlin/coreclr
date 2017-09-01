using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bne_un_r4_bne_un_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bne_un_r4_bne_un_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bne_un_r4\\bne_un_r4.cmd");
        }
    }
}
