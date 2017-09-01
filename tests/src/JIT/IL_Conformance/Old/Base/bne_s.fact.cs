using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_bne_s_bne_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_bne_s_bne_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\bne_s\\bne_s.cmd");
        }
    }
}
