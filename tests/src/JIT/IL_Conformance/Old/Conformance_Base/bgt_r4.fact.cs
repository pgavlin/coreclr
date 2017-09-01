using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_r4_bgt_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_r4_bgt_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_r4\\bgt_r4.cmd");
        }
    }
}
