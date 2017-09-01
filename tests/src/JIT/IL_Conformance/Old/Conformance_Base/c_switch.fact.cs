using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_switch_c_switch_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_switch_c_switch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_switch\\c_switch.cmd");
        }
    }
}
