using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_bgt_i8_bgt_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bgt_i8_bgt_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bgt_i8\\bgt_i8.cmd");
        }
    }
}
