using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_brtrue_brtrue_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_brtrue_brtrue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\brtrue\\brtrue.cmd");
        }
    }
}
