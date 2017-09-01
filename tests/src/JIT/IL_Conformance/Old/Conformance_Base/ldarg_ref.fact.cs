using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarg_ref_ldarg_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarg_ref_ldarg_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarg_ref\\ldarg_ref.cmd");
        }
    }
}
