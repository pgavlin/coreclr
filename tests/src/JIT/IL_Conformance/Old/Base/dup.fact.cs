using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_dup_dup_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_dup_dup_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\dup\\dup.cmd");
        }
    }
}
