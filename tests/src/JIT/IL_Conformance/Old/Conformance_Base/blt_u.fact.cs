using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_blt_u_blt_u_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_blt_u_blt_u_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\blt_u\\blt_u.cmd");
        }
    }
}
