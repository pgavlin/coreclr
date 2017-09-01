using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_shr_shr_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_shr_shr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\shr\\shr.cmd");
        }
    }
}
