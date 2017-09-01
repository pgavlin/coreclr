using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_i4_ldind_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_i4_ldind_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_i4\\ldind_i4.cmd");
        }
    }
}
