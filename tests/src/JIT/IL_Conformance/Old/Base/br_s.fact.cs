using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_br_s_br_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_br_s_br_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\br_s\\br_s.cmd");
        }
    }
}
