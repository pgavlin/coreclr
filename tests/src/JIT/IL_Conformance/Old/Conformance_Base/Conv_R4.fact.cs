using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_Conv_R4_Conv_R4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_Conv_R4_Conv_R4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\Conv_R4\\Conv_R4.cmd");
        }
    }
}
