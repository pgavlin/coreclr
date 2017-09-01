using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_shr_i4_shr_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_shr_i4_shr_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\shr_i4\\shr_i4.cmd");
        }
    }
}
