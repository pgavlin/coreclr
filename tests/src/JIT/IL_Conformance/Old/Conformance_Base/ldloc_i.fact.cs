using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldloc_i_ldloc_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldloc_i_ldloc_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldloc_i\\ldloc_i.cmd");
        }
    }
}
