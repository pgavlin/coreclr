using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_u_bgt_u_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_u_bgt_u_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_u\\bgt_u.cmd");
        }
    }
}
