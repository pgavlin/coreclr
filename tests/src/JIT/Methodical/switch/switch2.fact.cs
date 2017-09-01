using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _switch_switch2_switch2_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch2_switch2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch2\\switch2.cmd");
        }
    }
}
