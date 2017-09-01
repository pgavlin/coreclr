using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_u1_ldind_u1_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_u1_ldind_u1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_u1\\ldind_u1.cmd");
        }
    }
}
