using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_shl_u8_shl_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_shl_u8_shl_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\shl_u8\\shl_u8.cmd");
        }
    }
}
