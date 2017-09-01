using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_loopstrswitchgoto_d_loopstrswitchgoto_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_loopstrswitchgoto_d_loopstrswitchgoto_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\loopstrswitchgoto_d\\loopstrswitchgoto_d.cmd");
        }
    }
}
