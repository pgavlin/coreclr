using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_u4_cgt_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_u4_cgt_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_u4\\cgt_u4.cmd");
        }
    }
}
