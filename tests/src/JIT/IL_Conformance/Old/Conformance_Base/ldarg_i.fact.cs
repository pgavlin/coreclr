using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarg_i_ldarg_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarg_i_ldarg_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarg_i\\ldarg_i.cmd");
        }
    }
}
