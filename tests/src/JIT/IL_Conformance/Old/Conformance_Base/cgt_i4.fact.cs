using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_i4_cgt_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_i4_cgt_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_i4\\cgt_i4.cmd");
        }
    }
}
