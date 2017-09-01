using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldloc_ref_ldloc_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldloc_ref_ldloc_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldloc_ref\\ldloc_ref.cmd");
        }
    }
}
