using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _switch_switch1_switch1_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch1_switch1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch1\\switch1.cmd");
        }
    }
}
