using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldarg_n_ldarg_n_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldarg_n_ldarg_n_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldarg_n\\ldarg_n.cmd");
        }
    }
}
