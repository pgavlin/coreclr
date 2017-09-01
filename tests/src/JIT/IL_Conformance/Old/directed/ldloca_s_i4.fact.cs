using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloca_s_i4_ldloca_s_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloca_s_i4_ldloca_s_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloca_s_i4\\ldloca_s_i4.cmd");
        }
    }
}
