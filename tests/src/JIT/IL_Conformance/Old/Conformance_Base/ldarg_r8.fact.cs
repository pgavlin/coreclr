using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarg_r8_ldarg_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarg_r8_ldarg_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarg_r8\\ldarg_r8.cmd");
        }
    }
}
