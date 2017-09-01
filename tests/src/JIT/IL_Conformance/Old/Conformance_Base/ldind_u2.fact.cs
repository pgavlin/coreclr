using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_u2_ldind_u2_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_u2_ldind_u2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_u2\\ldind_u2.cmd");
        }
    }
}
