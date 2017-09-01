using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_u4_bgt_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_u4_bgt_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_u4\\bgt_u4.cmd");
        }
    }
}
