using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stind_r8_stind_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stind_r8_stind_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stind_r8\\stind_r8.cmd");
        }
    }
}
