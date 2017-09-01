using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_blt_i8_blt_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_blt_i8_blt_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\blt_i8\\blt_i8.cmd");
        }
    }
}
