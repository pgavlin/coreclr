using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_u8_cgt_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_u8_cgt_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_u8\\cgt_u8.cmd");
        }
    }
}
