using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarg_i8_ldarg_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarg_i8_ldarg_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarg_i8\\ldarg_i8.cmd");
        }
    }
}
