using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_bne_bne_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_bne_bne_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\bne\\bne.cmd");
        }
    }
}
