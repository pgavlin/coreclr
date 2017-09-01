using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_unaligned_unaligned_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_unaligned_unaligned_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\unaligned\\unaligned.cmd");
        }
    }
}
