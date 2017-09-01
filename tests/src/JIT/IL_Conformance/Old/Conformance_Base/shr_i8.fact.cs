using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_shr_i8_shr_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_shr_i8_shr_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\shr_i8\\shr_i8.cmd");
        }
    }
}
