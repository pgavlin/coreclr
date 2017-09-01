using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_not_u8_not_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_not_u8_not_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\not_u8\\not_u8.cmd");
        }
    }
}
