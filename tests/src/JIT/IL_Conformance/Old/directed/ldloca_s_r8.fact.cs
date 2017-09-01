using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldloca_s_r8_ldloca_s_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloca_s_r8_ldloca_s_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloca_s_r8\\ldloca_s_r8.cmd");
        }
    }
}
