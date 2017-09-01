using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldloc_i4_ldloc_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldloc_i4_ldloc_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldloc_i4\\ldloc_i4.cmd");
        }
    }
}
