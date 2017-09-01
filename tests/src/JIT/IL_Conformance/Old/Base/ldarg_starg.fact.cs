using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldarg_starg_ldarg_starg_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldarg_starg_ldarg_starg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldarg_starg\\ldarg_starg.cmd");
        }
    }
}
