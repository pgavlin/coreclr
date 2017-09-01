using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_div_i8_div_i8_
    {
        [Fact]
        public void _Old_Conformance_Base_div_i8_div_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\div_i8\\div_i8.cmd");
        }
    }
}
