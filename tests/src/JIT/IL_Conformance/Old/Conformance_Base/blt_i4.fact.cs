using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_blt_i4_blt_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_blt_i4_blt_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\blt_i4\\blt_i4.cmd");
        }
    }
}
