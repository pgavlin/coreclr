using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_ref_ldind_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_ref_ldind_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_ref\\ldind_ref.cmd");
        }
    }
}
