using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_brtrue_s_brtrue_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_brtrue_s_brtrue_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\brtrue_s\\brtrue_s.cmd");
        }
    }
}
