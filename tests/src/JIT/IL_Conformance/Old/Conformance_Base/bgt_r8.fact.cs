using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_r8_bgt_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_r8_bgt_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_r8\\bgt_r8.cmd");
        }
    }
}
