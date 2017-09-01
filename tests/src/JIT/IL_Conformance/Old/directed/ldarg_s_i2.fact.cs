using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_ldarg_s_i2_ldarg_s_i2_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldarg_s_i2_ldarg_s_i2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldarg_s_i2\\ldarg_s_i2.cmd");
        }
    }
}
