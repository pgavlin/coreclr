using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldloc_i8_ldloc_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldloc_i8_ldloc_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldloc_i8\\ldloc_i8.cmd");
        }
    }
}
