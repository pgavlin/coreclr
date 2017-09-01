using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_brtrue_brtrue_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_brtrue_brtrue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\brtrue\\brtrue.cmd");
        }
    }
}
