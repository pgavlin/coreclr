using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_u_cgt_u_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_u_cgt_u_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_u\\cgt_u.cmd");
        }
    }
}
