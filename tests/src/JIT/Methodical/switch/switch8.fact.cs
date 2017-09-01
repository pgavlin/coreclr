using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _switch_switch8_switch8_
    {
        [OuterLoop]
        [Fact]
        public void _switch_switch8_switch8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\switch\\switch8\\switch8.cmd");
        }
    }
}
