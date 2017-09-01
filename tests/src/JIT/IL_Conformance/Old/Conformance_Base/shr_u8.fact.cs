using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_shr_u8_shr_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_shr_u8_shr_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\shr_u8\\shr_u8.cmd");
        }
    }
}
