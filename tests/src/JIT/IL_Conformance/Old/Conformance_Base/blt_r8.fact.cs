using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_blt_r8_blt_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_blt_r8_blt_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\blt_r8\\blt_r8.cmd");
        }
    }
}
