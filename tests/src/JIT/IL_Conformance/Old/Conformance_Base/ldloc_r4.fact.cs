using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldloc_r4_ldloc_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldloc_r4_ldloc_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldloc_r4\\ldloc_r4.cmd");
        }
    }
}
