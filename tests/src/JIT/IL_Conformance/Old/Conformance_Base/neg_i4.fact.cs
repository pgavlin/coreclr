using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_neg_i4_neg_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_neg_i4_neg_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\neg_i4\\neg_i4.cmd");
        }
    }
}
