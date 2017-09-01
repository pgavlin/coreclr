using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_r4_ldind_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_r4_ldind_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_r4\\ldind_r4.cmd");
        }
    }
}
