using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bne_u8_bne_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bne_u8_bne_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bne_u8\\bne_u8.cmd");
        }
    }
}
