using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_neg_i8_neg_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_neg_i8_neg_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\neg_i8\\neg_i8.cmd");
        }
    }
}
