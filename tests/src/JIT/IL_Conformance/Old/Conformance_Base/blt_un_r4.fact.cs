using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_blt_un_r4_blt_un_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_blt_un_r4_blt_un_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\blt_un_r4\\blt_un_r4.cmd");
        }
    }
}
