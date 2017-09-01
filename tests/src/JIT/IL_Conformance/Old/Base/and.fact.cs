using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_and_and_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_and_and_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\and\\and.cmd");
        }
    }
}
