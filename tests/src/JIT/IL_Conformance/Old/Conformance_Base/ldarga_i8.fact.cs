using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarga_i8_ldarga_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarga_i8_ldarga_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarga_i8\\ldarga_i8.cmd");
        }
    }
}
