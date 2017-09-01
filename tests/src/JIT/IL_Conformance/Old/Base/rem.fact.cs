using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_rem_rem_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_rem_rem_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\rem\\rem.cmd");
        }
    }
}
