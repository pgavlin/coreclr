using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_or_u8_or_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_or_u8_or_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\or_u8\\or_u8.cmd");
        }
    }
}
