using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarg_i4_ldarg_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarg_i4_ldarg_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarg_i4\\ldarg_i4.cmd");
        }
    }
}
