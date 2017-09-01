using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_neg_r8_neg_r8_
    {
        [Fact]
        public void _Old_Conformance_Base_neg_r8_neg_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\neg_r8\\neg_r8.cmd");
        }
    }
}
