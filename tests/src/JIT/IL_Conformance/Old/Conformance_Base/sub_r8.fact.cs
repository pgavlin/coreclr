using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_sub_r8_sub_r8_
    {
        [Fact]
        public void _Old_Conformance_Base_sub_r8_sub_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_r8\\sub_r8.cmd");
        }
    }
}
