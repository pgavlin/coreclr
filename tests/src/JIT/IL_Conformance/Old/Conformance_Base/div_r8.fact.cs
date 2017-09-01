using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_div_r8_div_r8_
    {
        [Fact]
        public void _Old_Conformance_Base_div_r8_div_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\div_r8\\div_r8.cmd");
        }
    }
}
