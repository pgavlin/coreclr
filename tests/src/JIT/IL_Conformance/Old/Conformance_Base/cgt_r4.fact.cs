using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_r4_cgt_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_r4_cgt_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_r4\\cgt_r4.cmd");
        }
    }
}
