using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_loopstrswitchgoto_r_loopstrswitchgoto_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_loopstrswitchgoto_r_loopstrswitchgoto_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\loopstrswitchgoto_r\\loopstrswitchgoto_r.cmd");
        }
    }
}
