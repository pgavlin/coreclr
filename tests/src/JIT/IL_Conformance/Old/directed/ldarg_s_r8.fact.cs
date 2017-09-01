using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldarg_s_r8_ldarg_s_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldarg_s_r8_ldarg_s_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldarg_s_r8\\ldarg_s_r8.cmd");
        }
    }
}
