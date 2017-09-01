using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_blt_u4_blt_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_blt_u4_blt_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\blt_u4\\blt_u4.cmd");
        }
    }
}
