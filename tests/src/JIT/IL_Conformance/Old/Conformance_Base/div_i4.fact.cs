using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_div_i4_div_i4_
    {
        [Fact]
        public void _Old_Conformance_Base_div_i4_div_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\div_i4\\div_i4.cmd");
        }
    }
}
