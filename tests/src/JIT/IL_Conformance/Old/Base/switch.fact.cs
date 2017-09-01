using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_switch_switch_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_switch_switch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\switch\\switch.cmd");
        }
    }
}
