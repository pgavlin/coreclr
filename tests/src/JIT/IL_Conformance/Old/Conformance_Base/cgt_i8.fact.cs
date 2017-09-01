using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cgt_i8_cgt_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cgt_i8_cgt_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cgt_i8\\cgt_i8.cmd");
        }
    }
}
