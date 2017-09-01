using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_and_u8_and_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_and_u8_and_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\and_u8\\and_u8.cmd");
        }
    }
}
