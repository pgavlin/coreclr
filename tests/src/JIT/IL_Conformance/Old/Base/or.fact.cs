using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_or_or_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_or_or_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\or\\or.cmd");
        }
    }
}
