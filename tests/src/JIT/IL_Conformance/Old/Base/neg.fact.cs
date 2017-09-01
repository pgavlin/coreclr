using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_neg_neg_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_neg_neg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\neg\\neg.cmd");
        }
    }
}
