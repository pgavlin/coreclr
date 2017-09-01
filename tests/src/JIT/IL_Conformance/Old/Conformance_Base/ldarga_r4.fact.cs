using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarga_r4_ldarga_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarga_r4_ldarga_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarga_r4\\ldarga_r4.cmd");
        }
    }
}
