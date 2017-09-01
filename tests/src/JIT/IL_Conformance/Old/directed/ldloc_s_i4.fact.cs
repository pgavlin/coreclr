using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloc_s_i4_ldloc_s_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloc_s_i4_ldloc_s_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloc_s_i4\\ldloc_s_i4.cmd");
        }
    }
}
