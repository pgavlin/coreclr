using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_shr_u4_shr_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_shr_u4_shr_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\shr_u4\\shr_u4.cmd");
        }
    }
}
