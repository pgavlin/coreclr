using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_i1_ldind_i1_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_i1_ldind_i1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_i1\\ldind_i1.cmd");
        }
    }
}
