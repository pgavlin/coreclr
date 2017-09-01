using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloc_s_i1_ldloc_s_i1_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloc_s_i1_ldloc_s_i1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloc_s_i1\\ldloc_s_i1.cmd");
        }
    }
}
