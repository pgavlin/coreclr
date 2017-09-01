using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_i4_bgt_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_i4_bgt_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_i4\\bgt_i4.cmd");
        }
    }
}
