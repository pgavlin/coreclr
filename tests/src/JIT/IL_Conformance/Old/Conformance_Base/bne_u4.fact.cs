using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bne_u4_bne_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bne_u4_bne_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bne_u4\\bne_u4.cmd");
        }
    }
}
