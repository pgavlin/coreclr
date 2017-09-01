using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloca_s_r4_ldloca_s_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloca_s_r4_ldloca_s_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloca_s_r4\\ldloca_s_r4.cmd");
        }
    }
}
