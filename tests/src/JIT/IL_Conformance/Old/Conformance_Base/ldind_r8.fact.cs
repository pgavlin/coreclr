using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_r8_ldind_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_r8_ldind_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_r8\\ldind_r8.cmd");
        }
    }
}
