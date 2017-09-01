using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_blt_u8_blt_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_blt_u8_blt_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\blt_u8\\blt_u8.cmd");
        }
    }
}
