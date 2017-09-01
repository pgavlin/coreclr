using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarga_ref_ldarga_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarga_ref_ldarga_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarga_ref\\ldarga_ref.cmd");
        }
    }
}
