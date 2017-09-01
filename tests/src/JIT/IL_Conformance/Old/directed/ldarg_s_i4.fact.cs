using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldarg_s_i4_ldarg_s_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldarg_s_i4_ldarg_s_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldarg_s_i4\\ldarg_s_i4.cmd");
        }
    }
}
