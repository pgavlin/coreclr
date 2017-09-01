using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_i8_ldind_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_i8_ldind_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_i8\\ldind_i8.cmd");
        }
    }
}
