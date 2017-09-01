using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarg_r4_ldarg_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarg_r4_ldarg_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarg_r4\\ldarg_r4.cmd");
        }
    }
}
