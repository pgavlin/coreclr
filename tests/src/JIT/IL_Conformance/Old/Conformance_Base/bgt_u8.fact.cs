using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_u8_bgt_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_u8_bgt_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_u8\\bgt_u8.cmd");
        }
    }
}
