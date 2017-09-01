using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bne_u_bne_u_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bne_u_bne_u_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bne_u\\bne_u.cmd");
        }
    }
}
