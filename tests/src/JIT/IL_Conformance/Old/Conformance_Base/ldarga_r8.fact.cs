using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarga_r8_ldarga_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarga_r8_ldarga_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarga_r8\\ldarga_r8.cmd");
        }
    }
}
